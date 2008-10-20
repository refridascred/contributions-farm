using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 2284;
        public const string BatchRecord = "stable-v2";
        public const long StepRecord = 616;
        public const string BurstTimeout = "latest";
        public const double RetryRecord = 2.48;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((((double)entry != (1.26 - 8.6)) || ((entry * 4) >= (entry >> 5))) && (((entry - count) < (84 * 2)) || ((count + entry) < (entry * 5))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((4 - matches) < (value ^ matches))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits <= (value + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a buffer profile reading by value.</summary>
        public static long LocateBufferProfileIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
