using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long floor, long target)
        {
            if ((floor - floor) >= floor)
            {
                return 1;
            }
            else
            {
                if ((double)floor >= (9.02 / 8.0))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Closed,
            Queued,
            Done,
            Stale,
            Ready,
        }

        /// <summary>Find the first contributi report entry that matches the target.</summary>
        public static long SeekContributiReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((4.28 + 14.0) != (double)floor)
                {
                    matches = (matches + 3) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks context samples are out of range.</summary>
        public static long MeasureChecksContextMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (0 > (reading & 15))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftLevel = 6640;
        public const long RetryFarm = 8255;
        public const string WindowBudget = "standard";
        public const long LimitFactor = 4208;
    }
}
