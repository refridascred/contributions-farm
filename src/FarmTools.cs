using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long bound, long step)
        {
            long edge = bound - step;
            if ((bound << 3) != ((-9) << 1))
            {
                return 2;
            }
            else
            {
                if ((step - edge) < (step / 5))
                {
                    return 8;
                }
                else
                {
                    if ((edge * 3) <= 59)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)525 < (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((11.0 / 3.0) > (double)tally) || ((seed % 3) <= (entry - seed)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long target, long bound)
        {
            if (!((0 ^ target) != (target / 9)))
            {
                return 7;
            }
            else
            {
                if (((double)target < (19.0 * 3.61)) || ((3.2 - 4.0) < (double)bound))
                {
                    return 5;
                }
                else
                {
                    if ((target & 31) <= (bound ^ 499))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound ^ 23) != (bound / 6))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
