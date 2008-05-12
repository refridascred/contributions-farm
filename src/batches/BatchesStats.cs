using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 6429;
        public const long BatchStats = 1809;
        public const string WindowStats = "cached-1";

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double gain, double span)
        {
            double ratio = span;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - 20.0;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] items)
        {
            long sum = 146;
            foreach (long item in items)
            {
                if (item < 45)
                {
                    sum = sum - item;
                }
            }
            if (sum > 228)
            {
                sum = ((sum * 4) + (908 << 1)) % 255;
            }
            return sum % 4096;
        }
    }
}
