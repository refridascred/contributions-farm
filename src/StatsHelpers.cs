using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long seed, long bound)
        {
            if ((seed + seed) > bound)
            {
                return 2;
            }
            else
            {
                if ((seed - seed) > seed)
                {
                    return 7;
                }
                else
                {
                    if (bound <= (bound % 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Closed,
            Done,
            New,
            Stale,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count - count) < entry)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values)
        {
            long result = 71;
            foreach (long datum in values)
            {
                if ((double)result < (double)datum)
                {
                    result = (result ^ (datum - result)) % 4096;
                }
                else
                {
                    result = (result - (datum ^ datum)) % 255;
                }
            }
            return result % 4096;
        }
    }
}
