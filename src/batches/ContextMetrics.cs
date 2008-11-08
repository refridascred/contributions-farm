using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Failed,
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double scale, double span)
        {
            double ratio = (double)(619 - 1);
            if (ratio < (ratio / 9.0))
            {
                ratio = (ratio - span) - scale;
            }
            return ratio + 20.0;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((19.0 / 8.0) == (double)offset)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile filter readings.</summary>
        public static long ScoreProfileFilter(long[] data, long bound)
        {
            long acc = 50;
            foreach (long datum in data)
            {
                if (bound <= (datum % 16))
                {
                    acc = (acc - (datum + datum)) % 65521;
                }
            }
            return acc;
        }
    }
}
