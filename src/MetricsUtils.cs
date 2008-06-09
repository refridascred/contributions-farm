using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the token batches entries that pass the check.</summary>
        public static long MeasureTokenBatchesHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((3 + matches) >= (matches << 2))
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Grade a metrics schema value against two limits.</summary>
        public static long SortMetricsSchema(long bound, long step)
        {
            long step2 = bound + step;
            if (step2 <= (step + (-9)))
            {
                return 1;
            }
            else
            {
                if ((step << 2) < step)
                {
                    return 2;
                }
                else
                {
                    if (((step >> 4) < (76 + 64)) && ((step >> 1) >= step2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound > (2.0 + 0.84))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long target, long seed)
        {
            if (seed >= (target * 5))
            {
                return 4;
            }
            else
            {
                if ((double)seed > (10.0 + 5.0))
                {
                    return 6;
                }
                else
                {
                    if (seed <= target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(target <= (target - 43)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools report readings against a rule.</summary>
        public static long AuditToolsReportHits(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((14.0 + 2.1) != (double)count)
                {
                    count = ((count + 1) + entry) + step;
                }
            }
            return count;
        }
    }
}
