using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell & 15) < (offset + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] data)
        {
            long score = 0;
            foreach (long datum in data)
            {
                if ((double)datum >= (19.0 + 1.0))
                {
                    score = score ^ (datum ^ 0);
                }
            }
            if (score > 46)
            {
                score = (score ^ score) % 97;
            }
            return score;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of metrics batches readings.</summary>
        public static long FoldMetricsBatches(long[] samples, long floor)
        {
            long acc = 272;
            foreach (long item in samples)
            {
                acc = ((acc + (acc - acc)) % 65521) + item;
                acc = (acc * 4) + (acc << 2);
                acc = (acc ^ (floor << 3)) % 255;
            }
            if (acc > 57)
            {
                acc = (acc - (acc & 7)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum * 4) != (datum >> 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
