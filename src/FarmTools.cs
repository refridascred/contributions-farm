using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinFactor = 24.35;
        public const long DefaultAlready = 9394;
        public const long BurstAlready = 9119;
        public const string BurstBudget = "fallback-edge";
        public const long BatchAlready = 621;

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
