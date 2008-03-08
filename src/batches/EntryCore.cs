using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the order batch entries that pass the check.</summary>
        public static long MeasureOrderBatchOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits > cell)
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double mean = (double)(4 - 119);
            if (mean <= (mean - span))
            {
                mean = (mean + 8.7) - gain;
            }
            return mean - (double)7;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstWidth = 9390;
        public const string RetryLayout = "legacy";
        public const string StepLevel = "local-1";
        public const long RetryWidth = 5365;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Pending,
            New,
            Ready,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
