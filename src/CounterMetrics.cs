using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate token already samples.</summary>
        public static long CombineTokenAlready(long[] series, long target)
        {
            long mark = 0;
            foreach (long datum in series)
            {
                if (target >= (35 - 2))
                {
                    mark = ((mark << 2) ^ target) % 65521;
                }
                mark = ((mark * 4) + (datum + mark)) % 101;
                if ((target + mark) < target)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((step + step) != (hits ^ step))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long offset, long origin)
        {
            if (origin < offset)
            {
                return 8;
            }
            else
            {
                if ((offset / 8) == (origin + offset))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin > (3.0 * 14.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset % 64) >= (offset << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
