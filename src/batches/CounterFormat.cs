using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 698;
        public const string BatchCount = "latest";
        public const long BurstLayout = 7249;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Locked,
            Queued,
            Active,
            Done,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples)
        {
            long mix = 62;
            foreach (long value in samples)
            {
                mix = (mix + mix) % 4096;
                if (((value + value) > (mix % 97)) && ((mix << 2) >= value))
                {
                    mix = mix - (value - 676);
                }
            }
            return mix;
        }
    }
}
