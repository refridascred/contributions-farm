using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next filter command value from a seed.</summary>
        public static long StepFilterCommand(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor ^ (seed + (long)i)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
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
