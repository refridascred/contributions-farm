using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long origin, long seed)
        {
            long offset = origin + seed;
            if ((seed + offset) > (seed / 3))
            {
                return 8;
            }
            else
            {
                if ((seed + offset) != (origin >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin < (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if (520 >= (offset ^ origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long seed, long target)
        {
            if ((seed << 3) <= target)
            {
                return 4;
            }
            else
            {
                if (((double)target >= (9.0 / 6.0)) || (79 > (target >> 3)))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed <= 1.18)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 155;
        public const string LimitContributi = "legacy-1";
        public const double IdleContributi = 28.14;

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double rate, double bias)
        {
            double load = rate;
            if (load > bias)
            {
                load = load - (rate + load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (rate / 3.0)) - (double)(long)i;
            }
            return load - (4.8 * 1.1);
        }
    }
}
