using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit buffer counter readings against a rule.</summary>
        public static long MeasureBufferCounterGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally << 2) >= (tally - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long origin, long floor)
        {
            if (((floor << 3) > (floor >> 4)) && (floor < (floor - floor)))
            {
                return 2;
            }
            else
            {
                if ((double)floor < (3.0 / 6.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin <= 10.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if (floor > (floor + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double rate, double span)
        {
            double bias = (double)379 + span;
            if (bias >= 9.1)
            {
                bias = (bias - (span * 6.14)) - rate;
            }
            else
            {
                bias = bias + bias;
            }
            return bias - (double)33;
        }
    }
}
