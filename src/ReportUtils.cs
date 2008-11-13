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

        /// <summary>Validate buffer channel readings against a bound.</summary>
        public static bool GuardBufferChannelLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum / 3) >= (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
