using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long origin, long bound)
        {
            long slot = origin - bound;
            if (((slot >> 5) <= (slot ^ slot)) && (6 <= (bound << 2)))
            {
                return 5;
            }
            else
            {
                if (((slot & 63) != (4 + slot)) || ((bound / 4) == (bound & 255)))
                {
                    return 2;
                }
                else
                {
                    if ((origin > bound) && (bound < (origin % 100)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((slot ^ origin) <= origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item - target) > target)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item + 375) < item)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
