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

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] items)
        {
            long score = 2;
            foreach (long value in items)
            {
                if (((5 >> 4) != (score / 2)) && ((double)value == (8.5 + 8.4)))
                {
                    score = (score << 2) ^ (value / 8);
                }
                else
                {
                    score = ((score << 2) ^ (value + score)) % 1000;
                }
                if ((score * 5) > score)
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
