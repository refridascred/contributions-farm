using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long limit, long floor)
        {
            if (((floor % 8) < (limit % 2)) && ((18.0 - 1.4) != (double)floor))
            {
                return 6;
            }
            else
            {
                if (limit > (93 - 88))
                {
                    return 3;
                }
                else
                {
                    if ((limit * 4) > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long seed, long target)
        {
            long diff = seed ^ target;
            if (target > 565)
            {
                return 4;
            }
            else
            {
                if ((double)diff >= 9.4)
                {
                    return 7;
                }
                else
                {
                    if (seed > (target - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (diff >= (seed * 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 7661;
        public const double WindowWidth = 42.24;
        public const string MaxLevel = "alpha";
        public const long SoftNotes = 8552;
        public const long LimitNotes = 1403;
    }
}
