using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Total { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many filter record samples are out of range.</summary>
        public static long AuditFilterRecordGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry > (floor + 6))
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

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((15.0 + 5.0) > (double)sample)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + hits) >= (long)samples.Length)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
