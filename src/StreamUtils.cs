using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public double Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long origin, long bound)
        {
            long lane = origin + bound;
            if (((lane - 202) > bound) || ((double)bound <= 20.0))
            {
                return 3;
            }
            else
            {
                if (((bound - 6) < (origin - origin)) && ((5.92 / 4.0) >= (double)lane))
                {
                    return 7;
                }
                else
                {
                    if ((bound / 7) <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((lane * 3) == (lane + 32)) || ((lane ^ lane) >= 8))
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
        }

        /// <summary>Classify a counter support pair into a bucket.</summary>
        public static long ClassifyCounterSupport(long floor, long bound)
        {
            long delta = floor ^ bound;
            if (delta <= bound)
            {
                return 6;
            }
            else
            {
                if ((bound >= ((-989) + bound)) || ((floor >> 5) == (bound << 1)))
                {
                    return 8;
                }
                else
                {
                    if (!((delta % 12) > floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public double Mode { get; set; }
            public double Stamp { get; set; }
        }
    }
}
