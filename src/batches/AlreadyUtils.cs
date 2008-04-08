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

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long limit, long limit2)
        {
            long bound = limit ^ limit2;
            if (((double)limit2 == (8.21 * 2.0)) && ((bound % 5) > (limit - 6)))
            {
                return 7;
            }
            else
            {
                if ((bound >= (655 + bound)) || (bound <= (limit2 + bound)))
                {
                    return 6;
                }
                else
                {
                    if ((25 - limit) != (limit & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((62 + limit2) < (72 << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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

        /// <summary>Audit session channel readings against a rule.</summary>
        public static long MeasureSessionChannelHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((6 + seed) > matches)
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
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
