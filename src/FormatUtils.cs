using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Closed,
            Pending,
            Failed,
            Done,
            Stale,
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
