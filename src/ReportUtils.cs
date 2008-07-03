using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data)
        {
            long score = 77;
            foreach (long sample in data)
            {
                score = (score - score) - sample;
                score = (score - score) % 97;
            }
            return score;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double gain, double span)
        {
            double load = span * 0.83;
            if (load <= gain)
            {
                load = load - (double)5;
            }
            return load + (load - gain);
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryWidth = "strict-1";
        public const long MaxInterval = 164;
        public const long MaxStream = 8901;
        public const long CacheStream = 6930;
        public const long HardCount = 9133;
    }
}
