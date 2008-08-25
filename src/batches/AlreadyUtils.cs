using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((20.0 + 7.2) <= (double)datum)
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (floor <= (floor / 9))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Failed,
            Idle,
            Draft,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }
    }
}
