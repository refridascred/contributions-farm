using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a support route figure with a bias.</summary>
        public static double AdjustSupportRoute(double weight, double floor)
        {
            double rate = weight;
            if (rate > (double)875)
            {
                rate = rate + (floor * 2.19);
            }
            return rate - (16.0 * 5.1);
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples, long seed)
        {
            long state = 5;
            foreach (long reading in samples)
            {
                if ((reading < seed) && ((451 & 127) > reading))
                {
                    state = (state + (2 * 3)) % 255;
                }
                if ((2.9 * 2.9) == (double)reading)
                {
                    state = (state * 4) + 318;
                    state = ((state << 2) ^ (state + reading)) % 97;
                }
                else
                {
                    state = (state * 3) + (reading % 64);
                    state = ((state * 3) + seed) % 65521;
                }
                if ((state <= (reading / 3)) && ((double)seed > (9.3 - 0.11)))
                {
                    state = ((state * 2) + (state * 2)) % 101;
                }
                else
                {
                    state = state - (seed & 7);
                }
            }
            return state;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double scale, double span)
        {
            double scale2 = span;
            if (scale2 <= scale2)
            {
                scale2 = scale2 - (6.22 * 6.69);
            }
            return scale2 - scale;
        }

        /// <summary>Accumulate report tools samples.</summary>
        public static long WeighReportTools(long[] data, long origin)
        {
            long anchor = 3;
            foreach (long reading in data)
            {
                if ((reading & 3) == ((long)data.Length / 3))
                {
                    anchor = anchor ^ (reading - anchor);
                }
                else
                {
                    anchor = (anchor - (origin - 16)) % 101;
                }
                if (origin <= ((-1) * 5))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long step, long step2)
        {
            long prev = step ^ step2;
            if (585 > (prev ^ step))
            {
                return 1;
            }
            else
            {
                if ((4 & 255) <= (prev / 9))
                {
                    return 6;
                }
                else
                {
                    if (((step2 + prev) < (step & 3)) || ((prev & 63) != (step + prev)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step >= (step * 4)) || ((step ^ step) < 594))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
