using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state * 3) + (state * 3)) - (long)i2;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Roll a buffer graph counter forward.</summary>
        public static long SeriesBufferGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark << 2) ^ (6 - mark)) % 101;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstWidth = 2987;
        public const long BurstOrder = 8170;
        public const long IdleSize = 9011;
        public const string BaseOrder = "strict-v2";

        /// <summary>Measure how many route queue samples are out of range.</summary>
        public static long AuditRouteQueueHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (floor >= (hits - floor))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
