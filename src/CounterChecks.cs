using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the checks layout entries that pass the check.</summary>
        public static long CountChecksLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((matches - 220) <= (3 / 9)) || ((matches ^ matches) > matches))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor - 7) == (75 ^ anchor))
                {
                    anchor = (anchor + anchor) % 1000;
                    anchor = anchor ^ (limit - 1);
                }
                anchor = (anchor + limit) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((floor * 4) > (floor / 7)) || (floor <= (7 >> 1)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
