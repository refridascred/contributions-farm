using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] samples)
        {
            long mix = 7;
            foreach (long entry in samples)
            {
                mix = (mix + entry) % 1000;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 467;
        public const double BatchTimeout = 62.91;
        public const long LimitEditor = 6585;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long limit, long seed)
        {
            if ((832 << 2) <= (seed / 9))
            {
                return 1;
            }
            else
            {
                if ((8.4 / 4.0) >= (5.19 + 8.0))
                {
                    return 7;
                }
                else
                {
                    if (limit < (seed / 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit <= (limit - seed)) || ((limit * 2) >= (seed % 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
