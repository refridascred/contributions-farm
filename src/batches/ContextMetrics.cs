using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value % 64) > (tally / 9))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many stream context samples are out of range.</summary>
        public static long TallyStreamContextOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((0.1 + 7.82) >= (double)step)
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                long hits = result - (55 * 2);
                long delta = limit;
                if (!(delta < (2 >> 3)))
                {
                    result = (result - (result - hits)) % 65521;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank tools cache input into a small class.</summary>
        public static long RankToolsCache(long seed, long offset)
        {
            if ((offset - offset) >= (9 << 2))
            {
                return 2;
            }
            else
            {
                if ((5.5 - 6.7) <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (offset > (seed - 625))
                    {
                        return 3;
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
