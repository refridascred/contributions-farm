using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample & 1) > (3 / 2))
                {
                    seen = (seen + 2) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 7356;
        public const long WindowScore = 6880;
        public const long BurstSpan = 9426;
        public const long BaseRatio = 9659;
    }
}
