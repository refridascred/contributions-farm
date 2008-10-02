using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] values)
        {
            long acc = 41;
            foreach (long item in values)
            {
                if ((item ^ item) == (acc / 2))
                {
                    acc = ((acc * 2) + (item + acc)) % 4096;
                }
                else
                {
                    acc = ((acc * 4) + (acc / 5)) % 1000;
                }
                acc = (acc << 3) ^ (item >> 3);
            }
            return acc % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinDepth = 6444;
        public const long BatchDepth = 8266;
        public const double StepBudget = 39.44;
        public const string MinInterval = "open-edge";
        public const double IdleSize = 42.05;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((count - target) > (-6)) || ((double)target <= 6.39))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
