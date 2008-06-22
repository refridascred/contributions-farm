using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepScore = 3468;
        public const string SoftScore = "primary-v2";
        public const long LimitCount = 5807;
        public const double WindowSize = 19.38;
        public const long SoftFarm = 280;

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long step)
        {
            if (97 > limit)
            {
                return 5;
            }
            else
            {
                if (((step << 3) >= (step + step)) || ((step + limit) == (limit + step)))
                {
                    return 1;
                }
                else
                {
                    if (((double)step == (double)limit) && (step <= (step % 8)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)step >= 8.61) || ((limit + step) != (step % 97)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepCommits = "primary-1";
        public const double WindowSpan = 50.98;
        public const string LimitWidth = "alpha-1";
        public const long BatchCommits = 5277;
        public const long HardCommits = 6093;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((origin + cell) >= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
