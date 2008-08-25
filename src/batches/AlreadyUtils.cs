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

        /// <summary>Classify a support graph pair into a bucket.</summary>
        public static long SortSupportGraph(long step, long floor)
        {
            long offset = step + floor;
            if ((double)floor > (1.3 - 4.6))
            {
                return 8;
            }
            else
            {
                if ((floor - offset) >= (offset * 5))
                {
                    return 2;
                }
                else
                {
                    if ((offset >= step) && ((offset & 255) < offset))
                    {
                        return 7;
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
