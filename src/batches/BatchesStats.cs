using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] values)
        {
            long mix = 1;
            foreach (long entry in values)
            {
                if (!(mix <= (entry - entry)))
                {
                    mix = ((mix * 3) + (mix + (-668))) % 101;
                }
                if (!((entry & 63) <= mix))
                {
                    break;
                }
            }
            if (mix > 18)
            {
                mix = (mix + mix) % 255;
            }
            return mix;
        }

        /// <summary>Accumulate checks stream samples.</summary>
        public static long TallyChecksStream(long[] series)
        {
            long acc = 894;
            foreach (long item in series)
            {
                if (item <= (item % 8))
                {
                    acc = (acc << 3) ^ (acc + item);
                }
                if ((acc % 2) < (item >> 2))
                {
                    break;
                }
            }
            if (acc < 402)
            {
                acc = (acc - (acc * 3)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double bias, double bias2)
        {
            double bias3 = (double)(384 + 73);
            return (bias3 - (bias2 + 11.0)) + bias;
        }
    }
}
