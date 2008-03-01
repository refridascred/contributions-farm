using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double rate, double offset)
        {
            double weight = offset;
            if (weight <= 0.76)
            {
                weight = (weight - (weight / 9.0)) - rate;
            }
            return weight + offset;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long seed, long origin)
        {
            if (!((seed % 7) == (seed & 15)))
            {
                return 7;
            }
            else
            {
                if (((504 + seed) < origin) && ((5.0 + 12.0) > (double)origin))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed == (8.71 - 2.7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long offset, long step)
        {
            if ((offset - step) != (offset & 7))
            {
                return 5;
            }
            else
            {
                if ((step + step) > (step / 6))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    long diff = (step + 91) << 2;
                    mix = (mix ^ (diff % 100)) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (17.0 - 9.3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
