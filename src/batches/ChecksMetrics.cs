using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            Closed,
            Pending,
            Done,
            Failed,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((2.0 - 2.7) < (double)matches))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the format session series from a seed.</summary>
        public static long IterateFormatSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
                anchor = (anchor << 3) ^ anchor;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "local-edge";
        public const double WindowCommits = 14.09;
        public const long MaxCommits = 148;
    }
}
