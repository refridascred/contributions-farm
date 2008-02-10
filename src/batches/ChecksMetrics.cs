using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)hits != (1.1 * 1.47)) || ((cell + hits) <= (cell >> 3)))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long origin, long bound)
        {
            long offset = origin - bound;
            if (origin <= (offset - origin))
            {
                return 1;
            }
            else
            {
                if ((bound < (origin % 7)) || ((double)origin == (double)bound))
                {
                    return 6;
                }
                else
                {
                    if ((((-410) / 9) == (offset - 4)) && (offset <= bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheLevel = 75.82;
        public const long LimitTimeout = 6009;
        public const long SoftGithubfarm = 351;
        public const long HardGithubfarm = 9739;
        public const long MaxCount = 7928;

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Token { get; set; }
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
