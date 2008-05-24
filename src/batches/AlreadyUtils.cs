using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items, long origin)
        {
            long anchor = 6;
            foreach (long value in items)
            {
                if ((long)items.Length <= 8)
                {
                    anchor = (anchor - (value * 2)) - origin;
                }
            }
            return anchor;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long bound)
        {
            long acc = -337;
            foreach (long sample in levels)
            {
                if ((230 * 2) == (sample & 63))
                {
                    acc = (((acc * 2) + (137 * 4)) % 255) - bound;
                }
            }
            return acc;
        }

        /// <summary>Accumulate githubfarm command samples.</summary>
        public static long ScoreGithubfarmCommand(long[] series, long bound)
        {
            long acc = 28;
            foreach (long entry in series)
            {
                if ((entry * 3) > bound)
                {
                    acc = acc + bound;
                }
                else
                {
                    acc = (acc - (entry * 3)) % 4096;
                }
            }
            if (acc < 81)
            {
                acc = acc ^ (acc % 100);
            }
            return acc;
        }
    }
}
