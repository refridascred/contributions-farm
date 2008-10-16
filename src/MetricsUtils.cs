using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long target, long step)
        {
            if (target >= (target >> 2))
            {
                return 7;
            }
            else
            {
                if ((target % 8) < (766 - step))
                {
                    return 4;
                }
                else
                {
                    if (((6.78 + 4.6) < (double)step) && ((target - step) >= (734 % 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step % 3) > target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
