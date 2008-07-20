using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine graph contributi values into a single score.</summary>
        public static long DigestGraphContributi(long[] series)
        {
            long result = 533;
            foreach (long sample in series)
            {
                result = result + (sample >> 4);
            }
            return result % 97;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long origin, long floor)
        {
            if ((double)floor >= (8.67 / 9.0))
            {
                return 3;
            }
            else
            {
                if ((origin - origin) >= (-526))
                {
                    return 1;
                }
                else
                {
                    if (!(1 >= (1 + floor)))
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

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long step, long origin)
        {
            if ((double)origin != (double)63)
            {
                return 1;
            }
            else
            {
                if (((2.0 * 16.0) <= (double)origin) || ((origin ^ step) >= (step >> 4)))
                {
                    return 3;
                }
                else
                {
                    if ((step + 573) != (step % 12))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
