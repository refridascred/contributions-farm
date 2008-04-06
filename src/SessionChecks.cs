using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Locate a cluster checks reading by value.</summary>
        public static long SeekClusterChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a order editor value against two limits.</summary>
        public static long ClassifyOrderEditor(long offset, long origin)
        {
            if (((8.0 * 3.8) <= (double)origin) && (5 < (offset + offset)))
            {
                return 0;
            }
            else
            {
                if (((origin & 31) < (origin ^ origin)) && ((double)origin >= (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((origin & 1) <= (6 / 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((1.0 + 15.0) > (double)origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
