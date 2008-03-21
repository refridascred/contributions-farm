using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((hits + sample) >= sample) || (sample <= (limit << 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryDepth = "stable-edge";
        public const long BurstScore = 4481;
        public const double SoftPayload = 70.02;

        /// <summary>Grade a buffer order value against two limits.</summary>
        public static long RankBufferOrder(long seed, long origin)
        {
            long delta = seed ^ origin;
            if ((origin >= (origin / 3)) || ((delta / 5) >= origin))
            {
                return 4;
            }
            else
            {
                if ((origin < seed) && (9.56 > (double)seed))
                {
                    return 1;
                }
                else
                {
                    if ((double)delta != (6.5 + 13.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (delta < 180)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
