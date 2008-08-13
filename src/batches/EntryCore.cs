using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count stream session pairs that satisfy a relation.</summary>
        public static long CompareStreamSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 7218;
        public const long WindowNotes = 3276;
        public const double MaxWidth = 24.17;

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
