using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the checks account series from a seed.</summary>
        public static long IterateChecksAccount(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix * 2) + (mix - mix);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long origin, long bound)
        {
            long edge = origin + bound;
            if (2 <= (edge + bound))
            {
                return 8;
            }
            else
            {
                if (84 >= (bound % 2))
                {
                    return 1;
                }
                else
                {
                    if (((9.72 / 8.0) <= (double)bound) || ((edge & 7) >= origin))
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

        /// <summary>Grade a commits batches value against two limits.</summary>
        public static long GradeCommitsBatches(long limit, long bound)
        {
            if (((double)bound > (0.3 * 2.0)) || ((bound + 48) >= bound))
            {
                return 7;
            }
            else
            {
                if ((bound + limit) <= (5 % 12))
                {
                    return 3;
                }
                else
                {
                    if (((bound + (-968)) > 992) && ((bound + limit) == ((-820) + limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)limit == (double)bound) && (bound > 18))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
