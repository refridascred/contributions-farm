using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((target >> 1) > (target - entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Ratio { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Classify a checks channel pair into a bucket.</summary>
        public static long RankChecksChannel(long target, long bound)
        {
            long cur = target + bound;
            if (target < (target ^ cur))
            {
                return 2;
            }
            else
            {
                if (target <= 877)
                {
                    return 5;
                }
                else
                {
                    if ((target ^ 4) < (target + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the counter batches entries that pass the check.</summary>
        public static long AuditCounterBatchesHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading < 9.0)
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample + 6) < sample)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (cell >= (938 / 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
