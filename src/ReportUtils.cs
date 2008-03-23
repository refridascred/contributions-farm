using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((long)values.Length >= count)
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] items)
        {
            long result = 76;
            foreach (long cell in items)
            {
                if (result < (3 >> 1))
                {
                    result = ((result - result) % 97) + cell;
                }
            }
            return result;
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
