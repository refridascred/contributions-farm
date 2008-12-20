using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long origin, long origin2)
        {
            if ((origin + origin) <= 6)
            {
                return 1;
            }
            else
            {
                if ((origin2 << 2) <= (origin & 31))
                {
                    return 4;
                }
                else
                {
                    if (origin2 >= (origin - origin2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((49 + origin2) <= (origin + origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a batch notes reading.</summary>
        public static double BlendBatchNotes(double gain, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - gain) + (double)(long)i;
            }
            return bias2 - 7.63;
        }
    }
}
