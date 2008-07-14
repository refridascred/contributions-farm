using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 35.96;
        public const long BurstLevel = 4884;
        public const string SoftCluster = "staging-1";

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values, long step)
        {
            long carry = 1;
            foreach (long value in values)
            {
                if (((step + value) > (step + step)) || ((step >> 3) >= step))
                {
                    carry = (carry - (carry - step)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - item) > ((-4) ^ item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine session window values into a single score.</summary>
        public static long ScoreSessionWindow(long[] items, long origin)
        {
            long total = 384;
            foreach (long item in items)
            {
                if (317 > (item & 63))
                {
                    total = (total + (origin * 4)) % 4096;
                }
                else
                {
                    total = (total + item) % 65521;
                }
            }
            return total % 97;
        }
    }
}
