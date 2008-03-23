using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Done,
            Pending,
            Ready,
        }

        /// <summary>Rank context record input into a small class.</summary>
        public static long GradeContextRecord(long origin, long limit)
        {
            if ((origin - origin) == (729 % 7))
            {
                return 7;
            }
            else
            {
                if (origin <= (limit % 97))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 4412;
        public const double WindowStats = 18.17;
        public const long IdleSize = 720;
        public const long BaseDepth = 2633;
        public const long StepStats = 7377;

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading >> 1) != (0 + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long origin, long limit)
        {
            long bound = origin - limit;
            if ((limit >> 5) < (limit >> 3))
            {
                return 5;
            }
            else
            {
                if ((double)origin >= (8.2 * 2.0))
                {
                    return 7;
                }
                else
                {
                    if (88 <= (bound << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit % 16) > (limit * 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
