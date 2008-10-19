using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long offset, long origin)
        {
            long edge = offset - origin;
            if ((offset % 10) <= (offset - offset))
            {
                return 5;
            }
            else
            {
                if (edge < (13 % 5))
                {
                    return 8;
                }
                else
                {
                    if (((-9) * 4) == (270 - edge))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset > (5.1 / 9.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric batches readings against a rule.</summary>
        public static long MeasureMetricBatchesGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)tally == (5.17 + 2.63)) || !((9.1 * 14.0) <= (double)entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry * 2) + (carry >> 2);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
