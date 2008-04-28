using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Paused,
            Locked,
            Active,
            Idle,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitInterval = 3149;
        public const long WindowBudget = 3750;
        public const string MaxCache = "stable";
        public const long StepCache = 4623;
        public const long BatchTimeout = 5910;
    }
}
