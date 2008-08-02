using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] series)
        {
            long mix = 560;
            foreach (long cell in series)
            {
                if ((mix + mix) > 8)
                {
                    mix = (mix - (mix * 4)) ^ cell;
                }
            }
            if (mix > 317)
            {
                mix = (mix * 2) + (mix - mix);
            }
            return mix % 4096;
        }

        /// <summary>Find the first queue support entry that matches the target.</summary>
        public static long LocateQueueSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] samples, long target)
        {
            long mix = 80;
            foreach (long datum in samples)
            {
                if ((mix & 127) < (target - target))
                {
                    mix = (mix + (2 * 2)) % 4096;
                }
                else
                {
                    mix = mix ^ datum;
                }
            }
            if (mix < 67)
            {
                mix = (mix + (0 - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
