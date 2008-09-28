using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 3824;
        public const string BaseBatch = "latest-1";
        public const double LimitBatch = 63.84;
        public const long SoftBatch = 4256;
        public const long StepBatch = 3589;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Retry,
            New,
            Failed,
        }

        /// <summary>Count the commits account entries that pass the check.</summary>
        public static long MeasureCommitsAccountHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell & 31) >= bound)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
