using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits > (double)22)
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long target, long origin)
        {
            long step = target ^ origin;
            if ((target / 3) < (target - 436))
            {
                return 0;
            }
            else
            {
                if ((89 + target) <= (54 ^ step))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin <= (6.37 * 4.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + 9) != (origin * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 6.43;
        public const string BatchTimeout = "primary";
        public const long MaxChannel = 9706;
        public const long CacheChannel = 9223;
        public const long HardChannel = 4605;
    }
}
