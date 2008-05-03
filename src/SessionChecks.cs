using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long floor, long limit)
        {
            long span = floor - limit;
            if ((span >> 1) < (span - 783))
            {
                return 2;
            }
            else
            {
                if ((980 & 31) != (limit << 1))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleScore = 565;
        public const long SoftInterval = 4834;
        public const string SoftCount = "fallback-1";
        public const long BaseBuffer = 3669;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (13.0 > (double)seen)
                {
                    seen = ((seen + 2) + value) - floor;
                }
            }
            return seen;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
