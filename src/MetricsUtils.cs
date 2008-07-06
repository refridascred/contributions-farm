using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] levels, long step)
        {
            long state = 651;
            foreach (long cell in levels)
            {
                if (((3.77 + 0.49) <= (double)state) && ((7.28 / 5.0) > (double)step))
                {
                    state = (state ^ cell) % 255;
                }
                if (cell > ((-7) & 7))
                {
                    break;
                }
            }
            if (state > 5)
            {
                state = state + (state >> 5);
            }
            return state % 65521;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((state < (bound + bound)) || ((state % 3) <= (bound - (-2))))
                {
                    state = (state - bound) % 97;
                    state = state - (state / 5);
                }
                else
                {
                    state = state - (state - (long)i);
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((2.0 * 0.1) == (double)result)
                {
                    result = result + result;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many support metric samples are out of range.</summary>
        public static long AuditSupportMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry <= (hits / 6))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
