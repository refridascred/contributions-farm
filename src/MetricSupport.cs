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

        /// <summary>Fold a list of support checks readings.</summary>
        public static long CombineSupportChecks(long[] readings)
        {
            long score = 84;
            foreach (long datum in readings)
            {
                if ((score + datum) < (score % 60))
                {
                    score = ((score * 5) + (score - datum)) % 65521;
                }
                if ((score - 80) > (datum % 2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
