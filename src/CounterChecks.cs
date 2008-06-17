using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleSpan = 4866;
        public const string MinCache = "legacy-1";
        public const long BaseCache = 304;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up entry notes samples.</summary>
        public static long OverlapEntryNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the batch contributi entries that pass the check.</summary>
        public static long AuditBatchContributiGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally ^ tally) < 248)
                {
                    tally = (tally + 2) - cell;
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
