using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Rank commits farm input into a small class.</summary>
        public static long GradeCommitsFarm(long seed, long origin)
        {
            long diff = seed - origin;
            if (((diff % 97) <= origin) || ((diff - 651) != (diff + diff)))
            {
                return 8;
            }
            else
            {
                if (((seed * 2) <= diff) && ((165 % 60) != (seed >> 3)))
                {
                    return 7;
                }
                else
                {
                    if (((3 * 2) <= (diff & 127)) && ((double)seed > (6.5 - 3.3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((19.0 - 12.0) <= (double)diff)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up session metrics samples.</summary>
        public static long CompareSessionMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
