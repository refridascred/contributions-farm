using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long bound, long offset)
        {
            long slot = bound - offset;
            if ((10.0 - 8.2) == (double)slot)
            {
                return 0;
            }
            else
            {
                if (!((double)slot > (2.4 + 5.0)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long step, long floor)
        {
            if ((double)step >= (double)floor)
            {
                return 7;
            }
            else
            {
                if (floor < (step - step))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor < (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
