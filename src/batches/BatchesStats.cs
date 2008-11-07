using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long origin, long limit)
        {
            if (((0.5 - 4.0) > (double)limit) && ((origin + origin) >= (limit & 1)))
            {
                return 7;
            }
            else
            {
                if (((origin << 1) == (limit * 4)) && ((origin + limit) == (origin >> 4)))
                {
                    return 2;
                }
                else
                {
                    if (!((double)origin > (6.4 + 1.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of context route entries.</summary>
        public static long FoldContextRoute(long[] data)
        {
            long carry = -98;
            foreach (long reading in data)
            {
                if ((carry * 4) != (185 << 2))
                {
                    carry = ((carry + (carry - carry)) % 101) - reading;
                }
                else
                {
                    carry = (carry + 17) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings)
        {
            long mix = 912;
            foreach (long entry in readings)
            {
                mix = mix ^ (728 & 3);
                mix = ((mix << 3) ^ (entry % 10)) % 1000;
                if (((-311) - 20) >= (entry + mix))
                {
                    mix = (mix ^ 52) % 4096;
                }
                if (!(mix > (entry + mix)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
