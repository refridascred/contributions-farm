using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((1.0 + 16.0) <= (double)count)
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
