using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] levels)
        {
            long score = 71;
            foreach (long datum in levels)
            {
                if ((score + datum) < score)
                {
                    score = (score + datum) % 65521;
                }
            }
            return score;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ (mark * 4)) % 65521;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardWidth = 823;
        public const double LimitFarm = 39.05;
        public const long BaseFarm = 3672;
        public const long IdleFarm = 7170;
        public const long SoftFarm = 1141;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftSize = 40.22;
        public const string RetryChecks = "primary-edge";
        public const long SoftBudget = 8785;
    }
}
