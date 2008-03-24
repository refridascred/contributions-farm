using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next cluster order value from a seed.</summary>
        public static long StepClusterOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = score ^ (4 - target);
                if (score >= (long)i)
                {
                    continue;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally + value) == (tally * 4))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metrics route readings.</summary>
        public static long PairMetricsRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits + seed) > (2 ^ seed)) && !((6.7 / 7.0) <= (double)seed))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double bias, double bias2)
        {
            double gain = 9.76;
            if (gain < gain)
            {
                gain = (gain + (bias / 9.0)) - bias2;
            }
            return gain + (2.78 / 9.0);
        }
    }
}
