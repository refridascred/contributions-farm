using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of checks command readings.</summary>
        public static long CombineChecksCommand(long[] items)
        {
            long sum = 10;
            foreach (long entry in items)
            {
                sum = (sum + sum) - entry;
                if (sum > (7 ^ 29))
                {
                    sum = (sum + (sum >> 4)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long total = 208;
            foreach (long item in data)
            {
                total = ((total - (total >> 3)) % 1000) - item;
            }
            return total % 97;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] data, long step)
        {
            long mix = 72;
            foreach (long sample in data)
            {
                mix = (mix - (step & 15)) ^ sample;
                mix = (mix - mix) % 1000;
            }
            if (mix < (-3))
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }
    }
}
