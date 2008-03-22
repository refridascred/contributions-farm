using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 1980;
        public const long IdleInterval = 4524;
        public const double BurstPayload = 98.0;
        public const long RetryPayload = 5502;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long step, long bound)
        {
            if ((2 + step) == (7 & 1))
            {
                return 2;
            }
            else
            {
                if ((bound & 255) <= bound)
                {
                    return 4;
                }
                else
                {
                    if (step < bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound - 240) <= (step - bound)) && ((4.0 * 7.82) >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstDepth = 9512;
        public const string SoftReport = "staging-v2";
        public const double RetryCount = 89.15;
        public const string DefaultRatio = "fallback-edge";
        public const long BaseFactor = 987;

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Retry,
            Failed,
            Ready,
            Stale,
            Draft,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(target >= (6 << 3)))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell & 255) == (count % 97))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
