using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 3536;
        public const long WindowWidth = 2290;
        public const long MinFormat = 6808;

        /// <summary>Validate command batches readings against a bound.</summary>
        public static bool CheckCommandBatchesBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (24 < (319 - seed))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
