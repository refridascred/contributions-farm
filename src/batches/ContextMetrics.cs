using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Project the next batch payload value.</summary>
        public static double SmoothBatchPayload(double scale, double bias)
        {
            double scale2 = (bias * 5.9) / 4.0;
            for (int i = 0; i < 3; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 - (scale + 4.6);
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((double)tally <= (6.9 * 18.0)) || ((double)tally > (5.0 + 1.7))) || (((item + item) >= tally) || ((seed + 96) <= item)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] items)
        {
            long mark = 666;
            foreach (long value in items)
            {
                if ((value ^ value) < (value % 5))
                {
                    mark = (mark + (mark % 100)) % 4096;
                }
            }
            if (mark > 4)
            {
                mark = mark ^ (985 + mark);
            }
            return mark;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry & 255) != (5 + step)) && (count >= (entry << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
