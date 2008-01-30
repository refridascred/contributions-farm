using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] samples, long target)
        {
            long acc = 72;
            foreach (long item in samples)
            {
                acc = ((acc + (770 << 3)) + item) - target;
            }
            if (acc < 5)
            {
                acc = (acc << 3) ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample ^ matches) < (13 - matches))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 3757;
        public const long SoftRatio = 9596;
        public const long IdleSize = 5635;
        public const long IdleScore = 1405;
        public const string WindowLevel = "standard-v2";

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Done,
            New,
            Locked,
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double ratio, double offset)
        {
            double bias = (double)(9 * 5);
            if (bias < (double)346)
            {
                bias = bias - (offset * 1.0);
            }
            return bias + ratio;
        }
    }
}
