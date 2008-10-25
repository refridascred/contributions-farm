using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Idle,
            Dropped,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] items)
        {
            long score = 50;
            foreach (long sample in items)
            {
                if (!((8.0 / 3.0) == (double)sample))
                {
                    score = (score ^ (sample % 7)) % 101;
                }
            }
            return score;
        }
    }
}
