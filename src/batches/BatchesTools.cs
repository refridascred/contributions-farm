using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] values)
        {
            long anchor = 4;
            foreach (long entry in values)
            {
                if (((long)values.Length / 9) != (entry << 3))
                {
                    anchor = (anchor * 2) + (68 >> 5);
                }
                else
                {
                    anchor = (anchor + (6 - entry)) % 255;
                    anchor = anchor ^ (38 / 7);
                }
                anchor = (anchor + entry) % 101;
                anchor = (anchor << 2) ^ entry;
            }
            return anchor % 65521;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
