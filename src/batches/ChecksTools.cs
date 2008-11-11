using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!(((entry + entry) < (entry >> 3)) || ((matches >> 2) != (8 - matches))))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats context entry stays within the limit.</summary>
        public static bool VerifyStatsContextBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels, long bound)
        {
            long score = 998;
            foreach (long sample in levels)
            {
                score = (((score * 2) + score) % 1000) ^ sample;
            }
            if (score < 2)
            {
                score = (score ^ (bound / 7)) % 97;
            }
            return score;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            Failed,
            Done,
            Retry,
        }
    }
}
