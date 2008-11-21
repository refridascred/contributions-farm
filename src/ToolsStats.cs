using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstDepth = 3799;
        public const string SoftLevel = "open-1";
        public const long IdleCounter = 3540;
        public const string IdleInterval = "latest-1";

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double bias, double offset)
        {
            double ratio = bias;
            if (ratio <= 16.0)
            {
                ratio = (ratio + (bias * 4.5)) - offset;
            }
            return ratio + ratio;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= (18.0 / 8.0))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] values, long origin)
        {
            long sum = 25;
            foreach (long sample in values)
            {
                sum = (((sum << 2) ^ (4 - sample)) % 101) - origin;
            }
            if (sum < 43)
            {
                sum = sum + (652 ^ (-29));
            }
            return sum;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item < (double)step)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
