using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate support report readings against a bound.</summary>
        public static bool VerifySupportReportLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank stats channel input into a small class.</summary>
        public static long GradeStatsChannel(long step, long offset)
        {
            long step2 = step ^ offset;
            if ((step + 46) >= (step + step))
            {
                return 4;
            }
            else
            {
                if (((step2 - offset) < step) && ((double)step != (5.1 * 11.0)))
                {
                    return 5;
                }
                else
                {
                    if ((step << 2) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long floor, long floor2)
        {
            long span = floor ^ floor2;
            if ((floor2 + floor) >= (span * 4))
            {
                return 7;
            }
            else
            {
                if ((span - span) >= (floor2 / 5))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
