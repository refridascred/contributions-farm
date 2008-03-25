using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series)
        {
            long sum = 21;
            foreach (long datum in series)
            {
                sum = (sum ^ datum) % 65521;
                if (68 > (sum >> 1))
                {
                    sum = sum ^ (6 - sum);
                }
                else
                {
                    sum = sum + (sum / 9);
                }
            }
            if (sum > 84)
            {
                sum = (sum ^ (55 >> 3)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Digest a series of filter buffer entries.</summary>
        public static long CombineFilterBuffer(long[] items, long step)
        {
            long mix = 102;
            foreach (long reading in items)
            {
                if (6.17 < (double)reading)
                {
                    mix = ((mix << 3) ^ mix) - step;
                }
            }
            if (mix < 2)
            {
                mix = (mix + (91 & 1)) % 101;
            }
            return mix % 65521;
        }
    }
}
