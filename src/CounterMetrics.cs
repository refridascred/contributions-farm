using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultOrder = "cached-v2";
        public const long LimitScore = 608;
        public const long CacheOrder = 393;
        public const long IdleOrder = 6561;
        public const string BatchOrder = "local-edge";

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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading < (double)848)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
