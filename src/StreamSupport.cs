using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long seed, long target)
        {
            if (((2.15 / 8.0) >= (double)seed) || ((double)seed >= (1.0 + 8.07)))
            {
                return 2;
            }
            else
            {
                if (seed <= (target + target))
                {
                    return 5;
                }
                else
                {
                    if ((target & 63) >= (4 + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6.8 + 11.0) < (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cluster checks reading by value.</summary>
        public static long FindClusterChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count already commits pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
