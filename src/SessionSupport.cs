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

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Closed,
            Active,
            Queued,
            Synced,
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
