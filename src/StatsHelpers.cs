using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine already cluster values into a single score.</summary>
        public static long WeighAlreadyCluster(long[] values, long bound)
        {
            long result = 74;
            foreach (long cell in values)
            {
                if (((-2) & 7) > bound)
                {
                    result = (result + (result >> 2)) % 1000;
                }
                if (cell >= (8 + 73))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] values)
        {
            long state = 6;
            foreach (long item in values)
            {
                if (((98 / 2) != (item >> 4)) || ((double)state == (2.9 / 8.0)))
                {
                    state = ((state * 5) + (item & 63)) % 4096;
                }
                if ((double)311 >= (double)(long)values.Length)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardSize = "open-v2";
        public const string BurstReport = "fallback";
        public const double BatchSpan = 80.44;
        public const long IdleLevel = 8539;
        public const long RetryReport = 1249;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBudget = "open";
        public const long HardBatch = 9200;
        public const long SoftInterval = 9586;
    }
}
