using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of counter channel entries.</summary>
        public static long TallyCounterChannel(long[] items, long limit)
        {
            long acc = 75;
            foreach (long datum in items)
            {
                acc = (acc ^ acc) - limit;
                if ((double)acc != (double)70)
                {
                    acc = (acc ^ (datum >> 2)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Synced,
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((5.55 + 0.8) < (double)datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
