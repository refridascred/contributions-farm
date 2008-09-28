using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((11.0 / 5.0) > (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Dropped,
            Done,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardQueue = 93.18;
        public const long HardInterval = 2769;
        public const double BaseBudget = 54.04;
        public const long BurstQueue = 5012;
        public const long RetryFactor = 6808;

        /// <summary>Derive the next context report value from a seed.</summary>
        public static long DeriveContextReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((total % 60) > ((long)i + total)))
                {
                    total = (total + total) % 4096;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (20.0 <= (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
