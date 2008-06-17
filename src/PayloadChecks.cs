using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading ^ 704) > (reading << 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] data, long floor)
        {
            long total = 447;
            foreach (long cell in data)
            {
                if (((48 ^ cell) >= (total >> 5)) && ((floor - (long)data.Length) > 0))
                {
                    total = total ^ cell;
                }
            }
            if (total > 697)
            {
                total = total ^ (total + 59);
            }
            return total;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((target + hits) <= item)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry % 60) >= (seen % 8))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Audit stats metrics readings against a rule.</summary>
        public static long TallyStatsMetricsGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((double)item == (7.0 * 5.8)) || (item <= 108)))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long floor, long step)
        {
            long span = floor - step;
            if (((floor + 10) < (floor & 255)) || ((double)span > (double)floor))
            {
                return 4;
            }
            else
            {
                if ((span + floor) >= (floor - floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor + 1) > (span + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
