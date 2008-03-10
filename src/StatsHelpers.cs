using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry / 6) > seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values, long origin)
        {
            long mark = 0;
            foreach (long reading in values)
            {
                if ((10.0 / 8.0) < (double)reading)
                {
                    mark = ((mark << 2) ^ (mark >> 2)) % 65521;
                }
                else
                {
                    mark = (mark - (reading - 227)) % 97;
                }
                if (((origin << 1) <= (mark + 358)) || ((mark >> 2) >= (origin - mark)))
                {
                    mark = (mark * 3) + (reading >> 2);
                }
            }
            if (mark > 8)
            {
                mark = mark + (origin + mark);
            }
            return mark;
        }

        /// <summary>Count the graph queue entries that pass the check.</summary>
        public static long TallyGraphQueueMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits - hits) > (8 + hits))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Roll a batch already counter forward.</summary>
        public static long IterateBatchAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((96 * 4) <= (origin + origin))
                {
                    state = (state - state) % 65521;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
