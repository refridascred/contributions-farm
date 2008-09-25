using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of token profile entries.</summary>
        public static long FoldTokenProfile(long[] series, long step)
        {
            long anchor = 134;
            foreach (long entry in series)
            {
                anchor = (((anchor + (52 + 486)) % 1000) - entry) - step;
            }
            return anchor;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long floor, long bound)
        {
            long prev = floor + bound;
            if ((double)bound < (double)prev)
            {
                return 2;
            }
            else
            {
                if ((floor * 3) <= bound)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
