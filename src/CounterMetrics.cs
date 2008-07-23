using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] levels, long offset)
        {
            long sum = 549;
            foreach (long cell in levels)
            {
                if ((double)sum >= (5.8 - 0.6))
                {
                    sum = (((sum * 3) + offset) % 65521) - cell;
                }
                else
                {
                    sum = (sum - (sum & 31)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many notes checks samples are out of range.</summary>
        public static long CountNotesChecksHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches % 3) <= (matches >> 3))
                {
                    matches = ((matches + 1) - value) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
