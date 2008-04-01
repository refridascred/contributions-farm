using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long bound, long bound2)
        {
            long slot = bound + bound2;
            if (slot < (51 << 1))
            {
                return 5;
            }
            else
            {
                if ((bound2 - bound) >= (bound2 - bound2))
                {
                    return 0;
                }
                else
                {
                    if ((slot + 85) >= 132)
                    {
                        return 1;
                    }
                    else
                    {
                        if (slot >= (slot * 4))
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
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long floor, long bound)
        {
            long gap = floor ^ bound;
            if ((gap + 6) == (bound + bound))
            {
                return 1;
            }
            else
            {
                if (gap >= bound)
                {
                    return 7;
                }
                else
                {
                    if ((19.0 + 6.7) > (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Offset { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix + (long)i) % 255;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix ^ (mix ^ mix)) % 97) ^ (long)i2;
                }
                mix = mix + (mix * 4);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
