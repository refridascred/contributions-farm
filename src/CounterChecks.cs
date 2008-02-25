using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Done,
            Synced,
            New,
            Stale,
            Locked,
        }

        /// <summary>Audit account context readings against a rule.</summary>
        public static long CountAccountContextMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((991 >> 4) < (sample + 2))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of order support readings.</summary>
        public static long ScoreOrderSupport(long[] levels)
        {
            long total = 6;
            foreach (long datum in levels)
            {
                total = ((total + total) % 1000) + datum;
            }
            return total;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Active,
            Locked,
            Dropped,
            New,
            Draft,
        }

        /// <summary>Look up the position of a stream route sample.</summary>
        public static long SeekStreamRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
