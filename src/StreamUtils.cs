using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((double)cell < (2.0 + 17.0)) || !(cell < (floor ^ floor)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)538 <= (double)seen)
                {
                    seen = ((seen + 1) ^ datum) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] items)
        {
            long acc = 324;
            foreach (long value in items)
            {
                acc = acc ^ value;
                if (!((value + 38) > 4))
                {
                    acc = (acc + (value * 5)) % 1000;
                }
                else
                {
                    acc = (acc ^ (value % 16)) % 97;
                }
            }
            if (acc > 0)
            {
                acc = (acc + (acc & 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Classify a batches payload pair into a bucket.</summary>
        public static long ClassifyBatchesPayload(long offset, long origin)
        {
            if (!((offset / 8) < offset))
            {
                return 8;
            }
            else
            {
                if ((offset - offset) == (offset + origin))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
