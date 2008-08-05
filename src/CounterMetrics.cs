using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((2.62 * 0.6) >= (double)floor)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((double)result > (5.61 + 9.1))
                {
                    result = result - (origin - (long)i);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long limit, long step)
        {
            if ((step % 5) >= limit)
            {
                return 6;
            }
            else
            {
                if ((17.0 + 5.0) > (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((limit + limit) <= (step + step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] readings)
        {
            long total = 109;
            foreach (long reading in readings)
            {
                total = ((total - (-757)) % 4096) ^ reading;
            }
            if (total < 522)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
