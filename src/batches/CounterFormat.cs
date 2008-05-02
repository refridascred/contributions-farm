using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Done,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 6511;
        public const double BaseOrder = 12.44;
        public const string CacheOrder = "staging-edge";
        public const long IdleOrder = 6901;

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((tally & 31) >= 2) && (value < (11 % 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
