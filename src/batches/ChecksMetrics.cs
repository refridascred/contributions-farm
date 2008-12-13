using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate schema support readings against a bound.</summary>
        public static bool ValidateSchemaSupportLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of tools batches entries.</summary>
        public static long TotalToolsBatches(long[] readings)
        {
            long carry = -230;
            foreach (long value in readings)
            {
                if ((value + carry) != (value >> 4))
                {
                    carry = ((carry << 2) ^ (value - carry)) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every window entry entry stays within the limit.</summary>
        public static bool CheckWindowEntryBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 6889;
        public const long IdleReport = 6860;
        public const double LimitReport = 48.86;

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 4353;
        public const string BurstRoute = "strict-v2";
        public const string DefaultRoute = "latest-edge";
        public const long HardWidth = 7674;
        public const double LimitSpan = 25.91;
    }
}
