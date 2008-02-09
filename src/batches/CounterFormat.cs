using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine checks commits values into a single score.</summary>
        public static long ScoreChecksCommits(long[] data, long bound)
        {
            long anchor = 74;
            foreach (long item in data)
            {
                anchor = (((anchor << 2) ^ (25 - item)) % 97) + bound;
                if ((item + item) <= (654 & 127))
                {
                    break;
                }
            }
            if (anchor < 21)
            {
                anchor = (anchor ^ (947 + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowRatio = 6262;
        public const double StepFilter = 54.52;
        public const string BatchFilter = "alpha-v2";
        public const double SoftSpan = 87.12;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Done,
            Paused,
        }
    }
}
