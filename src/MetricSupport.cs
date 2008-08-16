using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long offset, long offset2)
        {
            if ((offset % 8) <= (offset >> 1))
            {
                return 5;
            }
            else
            {
                if ((offset + offset2) <= (offset * 5))
                {
                    return 2;
                }
                else
                {
                    if (offset >= 467)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset2 - offset2) == (offset2 ^ offset2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long seed, long seed2)
        {
            if (seed <= (seed2 ^ seed2))
            {
                return 4;
            }
            else
            {
                if ((seed2 + seed) <= (seed2 - 93))
                {
                    return 2;
                }
                else
                {
                    if ((seed2 % 60) == (seed2 / 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7 + seed2) > (seed - seed2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long offset, long limit)
        {
            if (((offset & 3) <= (offset & 15)) && ((limit ^ limit) >= (offset + offset)))
            {
                return 3;
            }
            else
            {
                if (offset < (limit & 1))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
