using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double weight, double span)
        {
            double ratio = (weight * 14.0) + weight;
            return ratio + (span + 3.21);
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long target, long floor)
        {
            if (((floor + 0) != (target - floor)) && ((double)target == (6.5 - 5.59)))
            {
                return 4;
            }
            else
            {
                if ((target * 5) == (floor >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((floor + target) != (floor - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 4096;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every stream schema entry stays within the limit.</summary>
        public static bool CheckStreamSchemaRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
