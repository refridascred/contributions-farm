using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long bound, long offset)
        {
            if (offset > (bound ^ offset))
            {
                return 7;
            }
            else
            {
                if ((bound ^ bound) > bound)
                {
                    return 8;
                }
                else
                {
                    if (offset >= (bound / 7))
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

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] data)
        {
            long mix = 8;
            foreach (long sample in data)
            {
                if (!(mix <= (mix + 80)))
                {
                    mix = (mix ^ (sample << 1)) % 101;
                }
                else
                {
                    mix = mix - (sample << 2);
                }
            }
            return mix;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long target, long floor)
        {
            long edge = target + floor;
            if ((floor ^ target) != (edge + (-793)))
            {
                return 4;
            }
            else
            {
                if ((double)edge >= 6.0)
                {
                    return 8;
                }
                else
                {
                    if ((double)edge <= (15.0 * 8.8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
