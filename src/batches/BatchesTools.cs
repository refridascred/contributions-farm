using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Level { get; set; }
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples, long limit)
        {
            long mark = 9;
            foreach (long reading in samples)
            {
                mark = ((mark - mark) ^ reading) - limit;
                mark = (mark + (416 << 2)) % 65521;
            }
            if (mark < 82)
            {
                mark = ((mark << 3) ^ (2 % 24)) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((limit << 3) != (item % 97))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
