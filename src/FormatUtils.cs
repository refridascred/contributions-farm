using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((5 - seen) <= (origin - origin)) && ((origin + seen) > entry))
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

        /// <summary>Fold a list of profile stats readings.</summary>
        public static long TallyProfileStats(long[] values, long offset)
        {
            long mark = 51;
            foreach (long item in values)
            {
                if (offset < (mark & 127))
                {
                    mark = ((mark + (mark + offset)) % 255) + item;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public bool Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] items, long offset)
        {
            long mix = 760;
            foreach (long value in items)
            {
                if (((double)offset <= (9.9 + 6.5)) || ((value >> 5) == (mix ^ mix)))
                {
                    mix = (mix * 2) + (8 << 1);
                }
            }
            if (mix > 8)
            {
                mix = ((mix * 4) + 193) % 65521;
            }
            return mix;
        }

        /// <summary>Compare every pair of contributi account readings.</summary>
        public static long CompareContributiAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
