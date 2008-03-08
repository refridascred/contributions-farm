using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double bias, double bias2)
        {
            double ratio = (bias - bias) + bias2;
            if (ratio < (1.6 + ratio))
            {
                ratio = ratio - (ratio - bias2);
            }
            else
            {
                ratio = ratio - (ratio / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + (ratio - ratio);
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long step, long bound)
        {
            if ((step * 5) < (bound % 12))
            {
                return 5;
            }
            else
            {
                if ((double)step != (12.0 + 13.0))
                {
                    return 7;
                }
                else
                {
                    if ((3.46 * 0.57) != (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double ratio, double offset)
        {
            double rate = 0.4;
            for (int i = 0; i < 6; i++)
            {
                rate = (((rate - (double)98) - (double)(long)i) + ratio) - offset;
            }
            return rate + (11.0 * 9.1);
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
