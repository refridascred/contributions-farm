using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long bound, long target)
        {
            long diff = bound + target;
            if (((2.2 + 1.82) <= (double)target) && ((27 ^ bound) <= (bound << 2)))
            {
                return 8;
            }
            else
            {
                if (diff > (bound * 5))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long seed)
        {
            long delta = limit + seed;
            if ((delta ^ seed) <= (delta << 1))
            {
                return 0;
            }
            else
            {
                if (delta < (delta ^ limit))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum <= (datum ^ datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Retry,
            Idle,
            Draft,
        }
    }
}
