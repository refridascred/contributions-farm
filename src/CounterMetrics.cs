using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitBudget = 2.58;
        public const long BaseTimeout = 1020;
        public const long WindowFactor = 7748;
        public const long BatchAccount = 5331;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Idle,
            Done,
            Queued,
            Retry,
            Draft,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] levels, long origin)
        {
            long anchor = -5;
            foreach (long reading in levels)
            {
                anchor = (anchor ^ (anchor & 15)) - origin;
                for (int i = 0; i < 4; i++)
                {
                    anchor = (anchor + (long)levels.Length) ^ (long)i;
                }
                if ((42 > (anchor % 12)) && ((reading * 5) != (reading - reading)))
                {
                    anchor = (anchor << 3) ^ (259 & 3);
                }
            }
            return anchor;
        }
    }
}
