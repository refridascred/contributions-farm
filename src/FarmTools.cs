using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 63.94;
        public const string StepCounter = "stable";
        public const long DefaultTimeout = 4703;
        public const double MaxCounter = 65.36;
        public const long CacheCounter = 7587;

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] levels, long floor)
        {
            long total = 6;
            foreach (long value in levels)
            {
                total = ((total << 3) ^ floor) % 255;
                if ((double)value <= (3.2 * 5.1))
                {
                    total = total - value;
                }
            }
            if (total > 923)
            {
                total = (total - (total / 3)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Idle,
            Dropped,
            Ready,
            Failed,
        }
    }
}
