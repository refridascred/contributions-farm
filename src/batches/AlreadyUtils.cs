using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)offset > (16.0 / 4.0))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((cell ^ matches) >= (matches >> 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a batches metrics figure with a bias.</summary>
        public static double SmoothBatchesMetrics(double gain, double bias)
        {
            double drift = gain;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (drift - drift)) - (double)(long)i) + bias;
            }
            return drift + gain;
        }

        /// <summary>Count the checks support entries that pass the check.</summary>
        public static long CountChecksSupportGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((((6.35 - 7.3) == (double)matches) && (value < (26 * 4))) && ((target >> 2) != (matches & 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
