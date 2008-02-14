using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long origin)
        {
            long score = 36;
            foreach (long sample in values)
            {
                if (score <= (sample * 2))
                {
                    score = (((score << 3) ^ score) % 4096) + origin;
                }
            }
            if (score > 7)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Classify a channel metric pair into a bucket.</summary>
        public static long RankChannelMetric(long floor, long limit)
        {
            long offset = floor - limit;
            if ((limit > (floor >> 5)) && ((limit + floor) > (617 ^ offset)))
            {
                return 3;
            }
            else
            {
                if (!((offset << 1) <= offset))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a support record value against two limits.</summary>
        public static long BucketSupportRecord(long target, long step)
        {
            if (((step + step) < step) || ((target % 24) <= 873))
            {
                return 1;
            }
            else
            {
                if (step >= (target * 3))
                {
                    return 4;
                }
                else
                {
                    if (!((step * 4) <= (target ^ step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - target) < target)
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
