using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of stream tools entries.</summary>
        public static long WeighStreamTools(long[] readings, long floor)
        {
            long result = 5;
            foreach (long sample in readings)
            {
                if ((floor < (sample - result)) && ((result + floor) <= result))
                {
                    result = (result + sample) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxTimeout = 6221;
        public const double SoftAlready = 39.23;
        public const double DefaultInterval = 50.32;
        public const string CacheLevel = "local-edge";

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Ready,
            Active,
        }
    }
}
