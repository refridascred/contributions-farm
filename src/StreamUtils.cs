using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a filter stream reading.</summary>
        public static double BlendFilterStream(double weight, double span)
        {
            double load = (double)(62 % 12);
            if (load > load)
            {
                load = load - (6.3 - weight);
            }
            else
            {
                load = load + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long target, long bound)
        {
            if (((8.0 / 2.0) <= (double)bound) && ((1.8 / 6.0) > (double)bound))
            {
                return 7;
            }
            else
            {
                if ((target / 2) != (target << 1))
                {
                    return 0;
                }
                else
                {
                    if ((bound < (target % 5)) || ((target & 31) >= target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultScore = 5131;
        public const long RetrySchema = 4220;
        public const long DefaultSchema = 6135;

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Size { get; set; }
            public bool Score { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }
    }
}
