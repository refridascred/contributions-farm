using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((origin + entry) <= 0) || ((546 + origin) <= (origin + origin)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Dropped,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Find the first format stream entry that matches the target.</summary>
        public static long LocateFormatStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
