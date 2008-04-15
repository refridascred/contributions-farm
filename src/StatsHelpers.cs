using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSize = 1560;
        public const long DefaultTimeout = 3107;
        public const long SoftEditor = 2006;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long bound, long origin)
        {
            if (!(origin < (bound & 15)))
            {
                return 1;
            }
            else
            {
                if ((double)bound == (15.0 - 2.68))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin >= (double)893)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((5.91 / 3.0) == (double)origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((52 * 4) != (hits % 3))
                {
                    hits = (hits + 2) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
