using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowInterval = 9339;
        public const long WindowCount = 3087;
        public const string RetryContext = "alpha-v2";
        public const long SoftDepth = 1653;
        public const long BaseDepth = 7058;

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheRoute = 30.68;
        public const long CacheWidth = 1838;
        public const long BurstFactor = 3809;
        public const string CacheSize = "legacy";

        /// <summary>Derive the next filter record value from a seed.</summary>
        public static long StepFilterRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = (result + (floor << 1)) % 97;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every stream schema entry stays within the limit.</summary>
        public static bool VerifyStreamSchemaLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Idle,
            Stale,
        }
    }
}
