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

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 8696;
        public const string IdleWidth = "staging";
        public const string MaxCount = "open-v2";
        public const long BatchBudget = 4070;
    }
}
