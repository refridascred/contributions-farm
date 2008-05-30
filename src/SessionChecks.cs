using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item / 6) < (item + item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] readings)
        {
            long score = 865;
            foreach (long entry in readings)
            {
                if (((score & 3) < (score >> 3)) || ((score + score) > 407))
                {
                    score = (((score * 2) + (9 >> 5)) % 1000) + entry;
                }
            }
            if (score > 914)
            {
                score = ((score << 3) ^ (score % 2)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
