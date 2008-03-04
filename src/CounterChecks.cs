using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a counter stats reading by value.</summary>
        public static long LookupCounterStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools notes readings against a rule.</summary>
        public static long TallyToolsNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((7 - datum) > (datum - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally << 1) >= (tally + entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Idle,
            New,
            Queued,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryBudget = 8435;
        public const long RetryLevel = 6257;
        public const long DefaultFormat = 1689;
    }
}
