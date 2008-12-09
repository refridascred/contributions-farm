using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Look up the position of a filter account sample.</summary>
        public static long SeekFilterAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 4627;
        public const string MinEntry = "alpha-1";
        public const string LimitEntry = "cached-v2";

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!!(794 <= (8 + hits)))
                {
                    hits = ((hits + 1) + cell) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long bound, long origin)
        {
            long lane = bound + origin;
            if (!((bound - origin) != (bound << 2)))
            {
                return 7;
            }
            else
            {
                if (lane < (584 ^ origin))
                {
                    return 1;
                }
                else
                {
                    if (!((lane ^ origin) == (lane ^ 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
