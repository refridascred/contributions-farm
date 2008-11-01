using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] levels, long floor)
        {
            long mix = 4;
            foreach (long reading in levels)
            {
                if ((16.0 / 5.0) < (double)floor)
                {
                    mix = (mix - reading) % 65521;
                }
                if ((mix - floor) < (long)levels.Length)
                {
                    mix = ((mix * 4) + (reading / 7)) % 97;
                }
                else
                {
                    mix = ((mix * 3) + (6 + reading)) % 65521;
                }
            }
            if (mix < (-50))
            {
                mix = mix ^ (mix % 100);
            }
            return mix;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Rank layout channel input into a small class.</summary>
        public static long ClassifyLayoutChannel(long origin, long limit)
        {
            if (4.92 < (double)limit)
            {
                return 3;
            }
            else
            {
                if ((1 + limit) >= (145 * 3))
                {
                    return 6;
                }
                else
                {
                    if (1.6 < (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long target, long target2)
        {
            if ((-770) >= target)
            {
                return 1;
            }
            else
            {
                if ((target % 10) >= target2)
                {
                    return 4;
                }
                else
                {
                    if (36 < (target * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)target <= (double)target2))
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

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Synced,
            Retry,
            Idle,
        }
    }
}
