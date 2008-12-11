using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine format graph values into a single score.</summary>
        public static long ScoreFormatGraph(long[] readings, long offset)
        {
            long score = 22;
            foreach (long entry in readings)
            {
                if (2 >= (score / 5))
                {
                    score = (((score << 2) ^ (entry / 5)) % 255) + offset;
                }
                else
                {
                    score = score - 50;
                }
            }
            return score % 65521;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] readings, long step)
        {
            long total = 86;
            foreach (long sample in readings)
            {
                if (!((sample - step) <= (step + total)))
                {
                    total = (total ^ 22) % 65521;
                }
                if ((step - 746) <= (step * 5))
                {
                    total = ((total * 5) + (sample ^ total)) % 65521;
                }
            }
            if (total > 0)
            {
                total = (total - (step - 725)) % 1000;
            }
            return total;
        }
    }
}
