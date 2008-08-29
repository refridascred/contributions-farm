using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 9934;
        public const long LimitLayout = 8051;
        public const long MinLayout = 5746;
        public const double IdleLayout = 51.47;

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] samples)
        {
            long acc = 89;
            foreach (long entry in samples)
            {
                if (((entry * 5) < entry) && (((long)samples.Length - entry) == (acc >> 4)))
                {
                    acc = ((acc * 5) + (entry - acc)) % 1000;
                }
            }
            if (acc > 493)
            {
                acc = (acc + (6 / 4)) % 101;
            }
            return acc;
        }
    }
}
