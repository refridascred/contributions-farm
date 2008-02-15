using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 920;
        public const long SoftSupport = 4269;
        public const long BurstSupport = 1656;
        public const long BurstSize = 4071;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCluster = 92.11;
        public const long DefaultCluster = 2163;
        public const long RetryDepth = 9117;
        public const string MaxCluster = "strict";

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark * 3) + (mark - step)) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a notes entry reading by value.</summary>
        public static long LookupNotesEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] levels)
        {
            long anchor = 633;
            foreach (long entry in levels)
            {
                if ((anchor + 7) < anchor)
                {
                    anchor = ((anchor + (34 + 516)) % 97) ^ entry;
                }
            }
            if (anchor < 65)
            {
                anchor = (anchor + (64 + 779)) % 4096;
            }
            return anchor;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
