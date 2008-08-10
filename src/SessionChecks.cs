using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long bound, long bound2)
        {
            if ((bound2 / 3) > (bound - 0))
            {
                return 3;
            }
            else
            {
                if (((0 << 2) < (bound2 + bound2)) || (((-8) << 3) <= bound2))
                {
                    return 8;
                }
                else
                {
                    if ((bound + bound) <= (15 * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((35 + bound) >= (bound * 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit batch tools readings against a rule.</summary>
        public static long AuditBatchToolsMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (1.24 >= (double)hits)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
