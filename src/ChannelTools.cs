using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitRatio = 63.68;
        public const double IdleTimeout = 17.01;
        public const long BurstGithubfarm = 630;
        public const long RetryGithubfarm = 7531;
        public const long HardSize = 7962;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                if (((result - 6) > (result ^ target)) && (result <= 226))
                {
                    result = (result - (target % 3)) % 101;
                    result = result ^ (target >> 4);
                    break;
                }
                else
                {
                    result = (result - (result * 5)) % 97;
                }
                if (!(((long)i << 2) >= target))
                {
                    result = (result + (9 & 255)) % 97;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
