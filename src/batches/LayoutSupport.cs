using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Locked,
            Queued,
            Done,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double bias)
        {
            double gain = (double)((-9) - 683);
            return (gain - (rate + 8.1)) + bias;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            New,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Iterate the filter buffer series from a seed.</summary>
        public static long RollFilterBuffer(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((mix + mix) >= mix)
                {
                    mix = ((mix << 2) ^ 19) % 4096;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine filter checks values into a single score.</summary>
        public static long TallyFilterChecks(long[] values, long floor)
        {
            long sum = 3;
            foreach (long reading in values)
            {
                sum = ((sum << 3) ^ (floor + floor)) ^ reading;
                sum = (sum ^ (sum << 1)) % 255;
            }
            if (sum > 169)
            {
                sum = (sum ^ (floor & 15)) % 97;
            }
            return sum % 4096;
        }
    }
}
