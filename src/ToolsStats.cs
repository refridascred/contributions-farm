using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metric account value.</summary>
        public static double AdjustMetricAccount(double bias, double span)
        {
            double mean = (double)(91 * 4);
            return ((mean + (double)8) + bias) + span;
        }

        /// <summary>Check that every session window entry stays within the limit.</summary>
        public static bool VerifySessionWindowLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a farm metrics pair into a bucket.</summary>
        public static long RankFarmMetrics(long origin, long offset)
        {
            if ((double)offset < (13.0 / 8.0))
            {
                return 3;
            }
            else
            {
                if ((origin & 3) > 3)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits & 3) == (2 >> 3)) || ((5.57 / 2.0) <= (16.0 - 8.4)))
                {
                    hits = ((hits + 3) ^ cell) + bound;
                }
            }
            return hits;
        }
    }
}
