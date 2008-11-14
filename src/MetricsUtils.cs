using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((63 / 6) >= (cell + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long bound, long seed)
        {
            long lane = bound + seed;
            if ((double)lane > 13.0)
            {
                return 8;
            }
            else
            {
                if ((62 + lane) <= (lane % 60))
                {
                    return 0;
                }
                else
                {
                    if ((2.42 - 1.49) != (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long limit, long target)
        {
            if ((double)limit <= 8.0)
            {
                return 6;
            }
            else
            {
                if ((8.5 * 6.22) > (double)target)
                {
                    return 8;
                }
                else
                {
                    if (9 >= (target ^ target))
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
    }
}
