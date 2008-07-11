using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first editor session entry that matches the target.</summary>
        public static long SeekEditorSessionIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "latest-edge";
        public const long DefaultMetrics = 9475;
        public const long CacheDepth = 7355;
        public const long BurstMetrics = 88;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum + tally) < (datum >> 5))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long target, long step)
        {
            long slot = target ^ step;
            if ((slot * 3) > target)
            {
                return 1;
            }
            else
            {
                if ((slot ^ slot) >= step)
                {
                    return 5;
                }
                else
                {
                    if (((slot + step) >= (1 + step)) || ((step ^ target) < (target & 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((slot & 255) > slot) && ((double)slot <= (1.0 * 19.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
