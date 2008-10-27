using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 2) ^ (acc + (-3))) % 101;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Idle,
            Ready,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long step, long step2)
        {
            if ((0 < (step2 - step2)) && ((step / 3) < (step2 - step2)))
            {
                return 7;
            }
            else
            {
                if ((0.08 / 4.0) != (double)step2)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
