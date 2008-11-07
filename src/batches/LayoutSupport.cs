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

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] readings)
        {
            long acc = 1;
            foreach (long cell in readings)
            {
                if ((5 < (cell % 10)) || (acc >= (8 << 1)))
                {
                    acc = acc ^ acc;
                }
                else
                {
                    acc = acc - (58 >> 2);
                }
                if (!((acc + cell) <= (cell + 2)))
                {
                    acc = ((acc << 3) ^ (cell >> 4)) % 101;
                }
                if ((acc + acc) > 639)
                {
                    break;
                }
            }
            return acc;
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
