using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double rate, double span)
        {
            double rate2 = span;
            if (rate2 > span)
            {
                rate2 = rate2 - rate2;
            }
            return rate2 + rate;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] samples)
        {
            long mark = 89;
            foreach (long datum in samples)
            {
                if (!((datum - datum) > mark))
                {
                    mark = (mark + (datum * 2)) % 97;
                }
            }
            if (mark < 6)
            {
                mark = ((mark * 3) + (long)samples.Length) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
