using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultScore = 5246;
        public const string IdleGithubfarm = "standard-edge";
        public const double RetryWidth = 60.26;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((10.0 / 2.0) == (double)bound) || (bound >= entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] items, long floor)
        {
            long mix = 457;
            foreach (long entry in items)
            {
                if (45 <= (floor + 2))
                {
                    mix = (mix ^ (mix - entry)) % 255;
                }
            }
            if (mix < 85)
            {
                mix = mix - (mix % 16);
            }
            return mix;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long bound, long limit)
        {
            long diff = bound ^ limit;
            if ((limit - limit) > (limit - bound))
            {
                return 2;
            }
            else
            {
                if ((bound / 8) >= bound)
                {
                    return 4;
                }
                else
                {
                    if (diff > (bound & 31))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((limit ^ diff) < (bound + 94)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
