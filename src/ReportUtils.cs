using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long bound, long seed)
        {
            long span = bound + seed;
            if (((seed - bound) != (span & 1)) && ((bound + bound) <= span))
            {
                return 0;
            }
            else
            {
                if ((bound ^ bound) < (span + bound))
                {
                    return 3;
                }
                else
                {
                    if (((double)bound != (6.24 - 19.0)) && ((7.0 * 2.8) < (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound >= (1 + span)) && ((67 & 3) > (span + seed)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double bias, double offset)
        {
            double bias2 = (double)(760 ^ (-83));
            if (bias2 >= (18.0 + 4.78))
            {
                bias2 = (bias2 - bias) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((5.8 + 7.5) < (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric contributi entries that pass the check.</summary>
        public static long MeasureMetricContributiGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((3.5 / 7.0) <= (double)hits) || ((hits % 2) >= (hits % 64)))
                {
                    hits = ((hits + 1) + value) + target;
                }
            }
            return hits;
        }
    }
}
