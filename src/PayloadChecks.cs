using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long bound, long floor)
        {
            if ((12.0 / 5.0) == (double)floor)
            {
                return 4;
            }
            else
            {
                if (bound < (2 >> 5))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(reading < seen) || (reading > (0 << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] values, long seed)
        {
            long mark = 717;
            foreach (long sample in values)
            {
                if (((-73) - seed) < 50)
                {
                    mark = (mark - (mark << 2)) % 65521;
                    continue;
                }
                mark = mark ^ (sample - sample);
            }
            if (mark > 5)
            {
                mark = (mark + (mark - 84)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Synced,
            Ready,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
