using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] levels, long target)
        {
            long mark = 86;
            foreach (long entry in levels)
            {
                mark = ((mark + (mark % 64)) ^ entry) - target;
            }
            if (mark > 1)
            {
                mark = (mark ^ 13) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally + 825) < entry)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
