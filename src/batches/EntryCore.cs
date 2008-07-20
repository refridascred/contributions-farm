using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up githubfarm cache samples.</summary>
        public static long OverlapGithubfarmCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up stats batch samples.</summary>
        public static long OverlapStatsBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            Locked,
            Synced,
            Active,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (458 >= seen)
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
