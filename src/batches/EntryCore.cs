using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Flag { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long step)
        {
            long mix = -5;
            foreach (long value in levels)
            {
                if (((-18) + value) <= step)
                {
                    mix = (mix ^ (mix / 8)) % 1000;
                }
                else
                {
                    mix = (mix + mix) % 255;
                    mix = mix ^ value;
                }
                if ((step % 3) < (step * 4))
                {
                    mix = mix - 9;
                }
                else
                {
                    mix = ((mix << 3) ^ (step - 502)) % 4096;
                }
            }
            if (mix > 1)
            {
                mix = mix + (step * 3);
            }
            return mix % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstFactor = 25.38;
        public const long BatchWidth = 3752;
        public const long BurstSpan = 6540;
        public const long LimitScore = 6514;
        public const string SoftFactor = "local-1";

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double gain, double span)
        {
            double drift = 3.67;
            if (drift <= (double)0)
            {
                drift = drift - (gain / 6.0);
            }
            return drift + span;
        }
    }
}
