using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count entry token pairs that satisfy a relation.</summary>
        public static long OverlapEntryTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next route checks value.</summary>
        public static double AdjustRouteChecks(double ratio, double offset)
        {
            double load = (offset / 5.0) - offset;
            if (load >= offset)
            {
                load = load + load;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (load + load)) + (double)(long)i;
            }
            return load - (ratio + offset);
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] data)
        {
            long anchor = 4;
            foreach (long item in data)
            {
                if (((item % 100) > (item / 8)) || ((item ^ anchor) <= (anchor - item)))
                {
                    anchor = ((anchor * 2) + (item & 3)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 3) + anchor) % 101;
                }
                if (68 > (item / 2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many buffer metric samples are out of range.</summary>
        public static long TallyBufferMetricMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) < (target % 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
