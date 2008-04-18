using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long offset, long floor)
        {
            long cur = offset - floor;
            if (floor > (cur ^ offset))
            {
                return 6;
            }
            else
            {
                if ((double)offset != (11.0 - 2.0))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series, long step)
        {
            long acc = 6;
            foreach (long entry in series)
            {
                if ((entry > (entry - 236)) || (((-77) ^ step) < (acc + 64)))
                {
                    acc = (acc - (entry - entry)) % 255;
                }
                else
                {
                    acc = acc + ((long)series.Length & 255);
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Retry,
            Draft,
            Locked,
            Idle,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (floor >= ((long)items.Length + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
