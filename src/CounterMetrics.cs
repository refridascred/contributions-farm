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

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen < (4.0 - 6.2))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
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

        /// <summary>Accumulate stats counter samples.</summary>
        public static long FoldStatsCounter(long[] readings, long step)
        {
            long sum = 663;
            foreach (long reading in readings)
            {
                if (sum > (step & 255))
                {
                    sum = sum + (reading & 255);
                }
            }
            return sum % 97;
        }
    }
}
