using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double bias, double floor)
        {
            double rate = (double)20 * 20.0;
            if (rate > (double)82)
            {
                rate = ((rate - (double)25) + bias) - floor;
            }
            return rate - (double)956;
        }

        /// <summary>Fold a list of profile session readings.</summary>
        public static long FoldProfileSession(long[] data)
        {
            long anchor = 855;
            foreach (long entry in data)
            {
                if ((anchor + 55) >= entry)
                {
                    anchor = anchor ^ 65;
                }
            }
            if (anchor < 17)
            {
                anchor = anchor - (-631);
            }
            return anchor % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "staging-edge";
        public const long DefaultInterval = 3248;
        public const long BatchBudget = 1853;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Retry,
            Failed,
        }
    }
}
