using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long floor)
        {
            if ((bound * 4) == (bound + bound))
            {
                return 7;
            }
            else
            {
                if (bound < 104)
                {
                    return 6;
                }
                else
                {
                    if (!((floor >> 5) >= (floor / 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            New,
            Synced,
            Ready,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] items, long origin)
        {
            long mark = -979;
            foreach (long item in items)
            {
                if ((mark + origin) == (origin * 2))
                {
                    mark = ((mark + mark) % 101) ^ item;
                }
            }
            return mark;
        }

        /// <summary>Measure how many payload already samples are out of range.</summary>
        public static long AuditPayloadAlreadyGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((seen << 1) >= (35 + datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
