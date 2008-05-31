using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Paused,
            Retry,
        }

        /// <summary>Classify a commits metric pair into a bucket.</summary>
        public static long BucketCommitsMetric(long target, long seed)
        {
            long span = target + seed;
            if ((span + span) < (seed * 5))
            {
                return 1;
            }
            else
            {
                if ((15.0 - 7.8) > (double)span)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((((60 >> 2) != (2 ^ count)) && ((54 + count) > (entry + entry))) || ((entry / 4) >= entry))
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

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
