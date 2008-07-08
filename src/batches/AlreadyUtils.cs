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

        /// <summary>Classify a command stats pair into a bucket.</summary>
        public static long SortCommandStats(long bound, long target)
        {
            if ((bound & 63) < (target << 1))
            {
                return 5;
            }
            else
            {
                if ((target ^ target) == (target % 7))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
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

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - 9) % 4096;
                carry = (carry - 7) % 4096;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
