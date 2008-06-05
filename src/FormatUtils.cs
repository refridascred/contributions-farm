using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((long)values.Length > item) || ((long)values.Length == (tally - item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + tally) <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a report token pair into a bucket.</summary>
        public static long BucketReportToken(long bound, long target)
        {
            if (!((bound << 3) <= target))
            {
                return 4;
            }
            else
            {
                if ((bound + 200) > 4)
                {
                    return 3;
                }
                else
                {
                    if (653 < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the context layout entries that pass the check.</summary>
        public static long AuditContextLayoutMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count ^ 8) >= (count % 2))
                {
                    count = ((count + 1) - reading) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
