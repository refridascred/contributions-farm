using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((state / 4) >= floor) && (((long)i >> 3) != (long)i))
                {
                    state = (state + (long)i) % 255;
                    state = (state << 3) ^ (floor + (long)i);
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long seed, long origin)
        {
            long lane = seed ^ origin;
            if (!((origin - 6) >= (82 & 15)))
            {
                return 5;
            }
            else
            {
                if ((seed & 15) >= (origin + 903))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed < (4.2 - 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)lane > (2.1 / 4.0)) || ((8.8 / 2.0) == (double)origin))
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
    }
}
