using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Closed,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] data)
        {
            long total = 5;
            foreach (long entry in data)
            {
                if ((double)total != (3.1 + 6.16))
                {
                    total = (total * 3) + (entry << 1);
                }
                total = (total << 2) ^ total;
            }
            return total;
        }

        /// <summary>Check that every account metrics entry stays within the limit.</summary>
        public static bool CheckAccountMetricsRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the payload farm entries that pass the check.</summary>
        public static long AuditPayloadFarmGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((60 * 5) < ((long)readings.Length * 5))
                {
                    seen = ((seen + 3) - datum) - limit;
                }
            }
            return seen;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
