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

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long target, long seed)
        {
            if (((5.46 * 15.0) > (double)target) && ((46 % 2) > (target + seed)))
            {
                return 2;
            }
            else
            {
                if ((0.2 * 5.0) >= (double)seed)
                {
                    return 1;
                }
                else
                {
                    return 7;
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
