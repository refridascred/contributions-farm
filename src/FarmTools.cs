using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] values, long bound)
        {
            long result = 25;
            foreach (long entry in values)
            {
                result = (((result << 2) ^ (result >> 1)) % 101) + bound;
                result = ((result * 3) + (160 * 3)) % 4096;
                result = ((result << 3) ^ (result - entry)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long bound, long bound2)
        {
            long prev = bound - bound2;
            if ((double)prev >= (17.0 - 7.0))
            {
                return 1;
            }
            else
            {
                if (((bound2 ^ bound2) > 879) || ((double)bound2 > (0.8 + 11.0)))
                {
                    return 5;
                }
                else
                {
                    if (((8 >> 3) > bound2) && ((double)prev > 8.59))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(8 < (bound2 + 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
