using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((item + item) >= (-820)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long bound, long limit)
        {
            if ((bound / 9) > (limit ^ limit))
            {
                return 4;
            }
            else
            {
                if ((bound >> 5) != (limit / 2))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long target, long origin)
        {
            if (!(origin > (target & 3)))
            {
                return 4;
            }
            else
            {
                if ((target < (origin * 2)) || ((origin / 4) > origin))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((sample & 3) != (step - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
