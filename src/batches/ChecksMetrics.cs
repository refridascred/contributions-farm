using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long target, long offset)
        {
            long edge = target ^ offset;
            if ((9.3 / 2.0) > (double)offset)
            {
                return 8;
            }
            else
            {
                if ((offset + edge) <= (274 * 3))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits > 8.66)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Weight { get; set; }
            public bool Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
