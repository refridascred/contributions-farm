using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Audit stream profile readings against a rule.</summary>
        public static long TallyStreamProfileHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (2.49 <= (double)step)
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every githubfarm metric entry stays within the limit.</summary>
        public static bool GuardGithubfarmMetricBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
