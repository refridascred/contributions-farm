using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Draft,
            Active,
            Synced,
            Dropped,
        }

        /// <summary>Fold a list of stream graph readings.</summary>
        public static long TallyStreamGraph(long[] levels)
        {
            long mark = 2;
            foreach (long item in levels)
            {
                mark = mark - (item >> 1);
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 1967;
        public const double BurstReport = 26.93;
        public const long BaseReport = 7877;
        public const long LimitDepth = 3004;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count / 3) < (count - item))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
