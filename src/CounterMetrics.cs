using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = mix - ((long)i + floor);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next order layout value.</summary>
        public static double ScaleOrderLayout(double weight, double span)
        {
            double load = (double)(45 >> 5);
            for (int i = 0; i < 9; i++)
            {
                load = (load + (span + weight)) + (double)(long)i;
            }
            return load + 4.9;
        }

        /// <summary>Grade a channel route value against two limits.</summary>
        public static long BucketChannelRoute(long origin, long limit)
        {
            long delta = origin + limit;
            if (19.0 > (double)limit)
            {
                return 8;
            }
            else
            {
                if ((937 + limit) != (limit >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((538 * 3) != (origin * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin - delta) <= limit)
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
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxTimeout = 7762;
        public const long SoftCommits = 4133;
        public const string LimitTimeout = "legacy-v2";
        public const long MaxSize = 3908;
        public const string RetryWidth = "legacy-1";
    }
}
