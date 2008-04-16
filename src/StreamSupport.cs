using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long offset, long floor)
        {
            if ((floor * 3) > (389 % 16))
            {
                return 1;
            }
            else
            {
                if ((floor + floor) <= (floor << 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)(-6) < (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long floor, long step)
        {
            if ((step >> 5) == (step + 18))
            {
                return 4;
            }
            else
            {
                if ((192 & 63) <= (floor - step))
                {
                    return 0;
                }
                else
                {
                    if ((floor / 6) <= ((-389) + step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor + floor) == (floor - 3)) && ((477 - floor) >= step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
