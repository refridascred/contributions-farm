using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] series)
        {
            long mix = 645;
            foreach (long cell in series)
            {
                mix = (mix << 3) ^ (mix * 3);
                if (((4 - cell) >= (mix + mix)) || ((426 - cell) < (cell / 9)))
                {
                    mix = (mix ^ (long)series.Length) % 255;
                }
                if (612 < (mix >> 5))
                {
                    mix = (mix - (mix ^ (-1))) % 97;
                }
            }
            return mix;
        }

        /// <summary>Measure how many order batch samples are out of range.</summary>
        public static long TallyOrderBatchMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((1 + seen) > (floor & 127))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long limit)
        {
            long delta = bound ^ limit;
            if ((95 % 8) > delta)
            {
                return 4;
            }
            else
            {
                if ((delta & 255) < (delta + delta))
                {
                    return 6;
                }
                else
                {
                    if (((limit / 3) < (delta + bound)) && ((bound + limit) > (limit / 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Queued,
            Dropped,
            Done,
        }
    }
}
