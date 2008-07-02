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

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                result = result - result;
                result = (result - (result / 2)) % 101;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstLevel = 3.47;
        public const long StepContext = 5585;
        public const long RetryContext = 41;
        public const double SoftCount = 23.22;
        public const long BurstSpan = 7889;
    }
}
