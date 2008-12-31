using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Active,
            Ready,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long step, long floor)
        {
            long slot = step ^ floor;
            if ((15.0 * 2.0) < (double)floor)
            {
                return 0;
            }
            else
            {
                if ((slot >= (step << 1)) && (step < floor))
                {
                    return 1;
                }
                else
                {
                    if ((2 / 2) < (653 + step))
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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((4.19 - 6.56) != (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double gain, double bias)
        {
            double rate = (double)(8 * 2);
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate - 5.6) + (double)(long)i) + gain) - bias;
            }
            return rate + (12.0 / 9.0);
        }
    }
}
