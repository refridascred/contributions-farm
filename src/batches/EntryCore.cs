using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((9.4 + 8.9) >= (double)hits)
                {
                    hits = ((hits + 1) + entry) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Rank notes session input into a small class.</summary>
        public static long BucketNotesSession(long offset, long step)
        {
            if ((12.0 - 5.51) < (double)offset)
            {
                return 6;
            }
            else
            {
                if ((step - step) < (step + step))
                {
                    return 0;
                }
                else
                {
                    if (((offset >> 5) <= (offset + step)) || (offset >= (step + 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step * 2) > (offset << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
