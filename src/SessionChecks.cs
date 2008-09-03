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

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((seen - 61) > (477 - seen)))
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
