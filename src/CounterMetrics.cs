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

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
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

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] levels, long origin)
        {
            long score = 423;
            foreach (long reading in levels)
            {
                if ((double)origin < (8.0 - 9.7))
                {
                    score = score ^ (reading / 4);
                }
            }
            if (score > 5)
            {
                score = ((score * 2) + (score + score)) % 4096;
            }
            return score;
        }
    }
}
