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

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i / 2) <= ((long)i << 3))
                {
                    anchor = (anchor * 5) + step;
                }
                if (7 > (step << 3))
                {
                    anchor = ((anchor * 5) + (long)i) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
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
