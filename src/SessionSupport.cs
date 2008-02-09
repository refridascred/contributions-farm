using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            New,
            Draft,
            Synced,
        }

        /// <summary>Digest a series of support cache entries.</summary>
        public static long TallySupportCache(long[] values, long target)
        {
            long score = 1;
            foreach (long sample in values)
            {
                score = ((score + (target * 3)) % 65521) - sample;
                if ((target + target) != ((long)values.Length + score))
                {
                    score = (score + (score ^ target)) % 255;
                }
            }
            if (score > 4)
            {
                score = score ^ score;
            }
            return score % 97;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            New,
            Stale,
            Draft,
        }
    }
}
