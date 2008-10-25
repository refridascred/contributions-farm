using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 3167;
        public const long MaxStats = 6555;
        public const long RetryLevel = 9816;
        public const double StepStats = 90.76;
        public const string SoftStats = "primary-edge";

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count > (67 % 8)) && (count > value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Pending,
            Stale,
        }
    }
}
