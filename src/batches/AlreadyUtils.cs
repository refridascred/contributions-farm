using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value < (9.9 + 3.65))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)matches < 2.0) && ((matches - matches) > (entry + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data, long floor)
        {
            long mix = 2;
            foreach (long item in data)
            {
                if ((4.24 - 2.0) < (double)floor)
                {
                    mix = (mix << 3) ^ (mix + item);
                }
                else
                {
                    mix = ((mix << 2) ^ (floor + 410)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Rank batch buffer input into a small class.</summary>
        public static long ClassifyBatchBuffer(long floor, long bound)
        {
            long edge = floor + bound;
            if ((floor << 2) <= (edge % 2))
            {
                return 2;
            }
            else
            {
                if (282 >= (floor % 8))
                {
                    return 8;
                }
                else
                {
                    if ((492 / 3) > (bound ^ edge))
                    {
                        return 1;
                    }
                    else
                    {
                        if (5 < (bound + bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a checks queue reading.</summary>
        public static double SmoothChecksQueue(double gain, double bias)
        {
            double mean = gain;
            if (mean > (double)607)
            {
                mean = (mean + gain) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (6.3 / 9.0)) + (double)(long)i;
            }
            return mean + (18.0 / 8.0);
        }
    }
}
