using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every contributi commits entry stays within the limit.</summary>
        public static bool ValidateContributiCommitsRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of already support readings.</summary>
        public static long TallyAlreadySupport(long[] series, long seed)
        {
            long mix = 619;
            foreach (long entry in series)
            {
                if ((seed & 255) != (entry + seed))
                {
                    mix = (mix + (seed - 75)) % 101;
                }
                else
                {
                    mix = ((mix << 2) ^ seed) % 97;
                }
            }
            if (mix < 5)
            {
                mix = (mix * 3) + (0 % 97);
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] items, long limit)
        {
            long acc = 6;
            foreach (long entry in items)
            {
                acc = (acc - (entry / 7)) % 1000;
                if (entry >= (acc + entry))
                {
                    acc = ((acc << 2) ^ (limit + entry)) % 4096;
                }
            }
            if (acc < 1)
            {
                acc = (acc - (acc >> 5)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Count the stream report entries that pass the check.</summary>
        public static long MeasureStreamReportHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item >> 3) > (long)items.Length)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
