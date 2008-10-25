using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every checks command entry stays within the limit.</summary>
        public static bool VerifyChecksCommandLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many metric checks samples are out of range.</summary>
        public static long TallyMetricChecksHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((datum & 255) == (matches - datum)) && !((7.51 + 4.96) > (double)matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] values, long seed)
        {
            long mix = 713;
            foreach (long cell in values)
            {
                mix = (((mix + (mix & 31)) % 1000) + cell) - seed;
            }
            return mix % 4096;
        }
    }
}
