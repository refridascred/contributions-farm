using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((step ^ tally) >= (sample ^ sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((6.42 < (1.8 / 2.0)) || (count <= (datum + datum))) && ((datum ^ (long)samples.Length) > (datum << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum - count) <= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit farm batch readings against a rule.</summary>
        public static long AuditFarmBatchGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((2.2 / 6.0) >= (double)offset) || (1.18 >= (double)(long)levels.Length))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
