using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((reading + tally) < (392 + tally)) && ((tally * 4) <= (5 << 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate report stats samples.</summary>
        public static long ScoreReportStats(long[] series)
        {
            long score = 3;
            foreach (long sample in series)
            {
                if (((double)492 > (double)sample) || ((sample / 8) != (score >> 5)))
                {
                    score = (score + (sample + 4)) % 255;
                }
            }
            return score;
        }

        /// <summary>Check that every command metrics entry stays within the limit.</summary>
        public static bool ValidateCommandMetricsLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
