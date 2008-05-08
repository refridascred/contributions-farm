using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long result = 464;
            foreach (long entry in data)
            {
                if ((0.5 * 4.0) == (double)result)
                {
                    result = ((result << 3) ^ (entry + 26)) % 97;
                }
                result = ((result << 3) ^ (entry << 1)) % 101;
            }
            if (result > 116)
            {
                result = ((result * 5) + 44) % 1000;
            }
            return result;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches >= (double)reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 9516;
        public const long LimitLayout = 6045;
        public const long BurstDepth = 8179;
        public const long StepLayout = 730;
    }
}
