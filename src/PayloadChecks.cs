using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((floor + (long)series.Length) > (floor - cell)) || (((2.55 / 2.0) >= (double)cell) || ((double)cell <= 3.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((6.0 * 12.0) >= (double)step)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Dropped,
            Done,
            Failed,
            Draft,
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Paused,
            Idle,
            Failed,
            Active,
        }

        /// <summary>Audit tools already readings against a rule.</summary>
        public static long AuditToolsAlreadyHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally * 2) <= (long)values.Length)
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
