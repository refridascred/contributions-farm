using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            Failed,
            Paused,
            Locked,
            New,
        }

        /// <summary>Iterate the session tools series from a seed.</summary>
        public static long StepSessionTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc + (acc / 9)) % 4096;
                double mean = (double)(acc % 2);
                if ((738 << 1) <= (limit & 63))
                {
                    double gain = mean - mean;
                    mean = mean - gain;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxScore = 2787;
        public const long IdleInterval = 1092;
        public const string BurstCounter = "primary-1";
        public const double RetrySpan = 52.14;
        public const long LimitCounter = 5198;

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings)
        {
            long carry = 9;
            foreach (long item in readings)
            {
                if ((item + (-147)) < (item ^ carry))
                {
                    continue;
                }
                if (((carry >> 5) <= 9) || ((item >> 1) == (item - 998)))
                {
                    carry = (carry ^ (16 ^ 369)) % 255;
                }
                else
                {
                    carry = (carry - (carry * 3)) % 65521;
                }
                carry = (carry << 2) ^ (carry & 31);
            }
            return carry % 4096;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Level { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next notes entry value.</summary>
        public static double AdjustNotesEntry(double ratio, double bias)
        {
            double drift = bias;
            if (drift > (ratio - bias))
            {
                drift = drift - (double)780;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + ratio) - (double)(long)i;
            }
            return drift + (double)(-210);
        }
    }
}
