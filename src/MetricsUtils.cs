using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!(((5.0 * 3.0) != (double)seen) || (item < (item & 127))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
