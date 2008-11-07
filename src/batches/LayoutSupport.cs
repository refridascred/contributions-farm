using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] values)
        {
            long total = 166;
            foreach (long sample in values)
            {
                total = (total - total) % 4096;
                total = ((total * 4) + (sample & 3)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Active,
            Failed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 5602;
        public const double RetryReport = 63.18;
        public const string BaseTimeout = "staging-1";
        public const string BaseReport = "local";

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] items, long target)
        {
            long anchor = 58;
            foreach (long reading in items)
            {
                anchor = ((((anchor << 2) ^ ((long)items.Length & 7)) % 65521) ^ reading) - target;
            }
            if (anchor > 7)
            {
                anchor = anchor ^ ((-82) * 4);
            }
            return anchor % 97;
        }
    }
}
