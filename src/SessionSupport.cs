using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data, long origin)
        {
            long result = 28;
            foreach (long datum in data)
            {
                if ((14.0 / 9.0) != (double)(long)data.Length)
                {
                    result = (((result << 3) ^ datum) % 101) - origin;
                }
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 10.94;
        public const long DefaultContributi = 1168;
        public const string BatchContributi = "legacy";
        public const long BurstWidth = 47;
        public const double SoftContributi = 18.42;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches + entry) != (limit + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
