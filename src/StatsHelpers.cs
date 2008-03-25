using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up entry schema samples.</summary>
        public static long PairEntrySchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Failed,
            Locked,
            Retry,
            Paused,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] series, long target)
        {
            long mark = 75;
            foreach (long entry in series)
            {
                if (!((double)entry >= (9.75 / 5.0)))
                {
                    mark = (mark << 2) ^ (mark - entry);
                }
            }
            if (mark > 45)
            {
                mark = (mark * 2) + (target - mark);
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstSize = 233;
        public const string StepBudget = "legacy-1";
        public const double IdleGithubfarm = 34.28;
        public const long BaseSize = 9619;
    }
}
