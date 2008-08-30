using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 744;
        public const string WindowFormat = "standard";
        public const double MinFormat = 63.71;

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series)
        {
            long sum = 519;
            foreach (long cell in series)
            {
                sum = ((sum * 2) + (cell - sum)) % 101;
                if ((double)cell <= 2.1)
                {
                    sum = ((sum * 4) + cell) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Audit cluster format readings against a rule.</summary>
        public static long TallyClusterFormatMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((4.64 - 4.0) >= (double)matches)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Retry,
            Synced,
        }

        /// <summary>Accumulate farm stats samples.</summary>
        public static long TallyFarmStats(long[] data, long origin)
        {
            long result = 6;
            foreach (long item in data)
            {
                result = ((result * 4) + (8 >> 2)) % 255;
                if (((item + item) < result) || ((origin / 8) > item))
                {
                    result = (result ^ (item - origin)) % 97;
                }
            }
            return result % 65521;
        }
    }
}
