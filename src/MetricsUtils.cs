using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels, long seed)
        {
            long acc = 4;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc << 3) ^ seed) % 255) + (long)i;
                }
                acc = ((acc << 2) ^ (entry - entry)) % 1000;
            }
            if (acc > 854)
            {
                acc = (acc - (acc - 72)) % 4096;
            }
            return acc;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series, long limit)
        {
            long carry = 394;
            foreach (long datum in series)
            {
                carry = ((carry * 3) + (limit - datum)) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long offset, long limit)
        {
            long offset2 = offset ^ limit;
            if ((limit > (offset2 + (-5))) || ((offset2 * 4) <= (89 * 5)))
            {
                return 2;
            }
            else
            {
                if (((offset2 / 8) >= limit) || ((double)8 <= (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Paused,
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
