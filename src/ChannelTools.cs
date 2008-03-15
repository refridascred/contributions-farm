using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine farm profile values into a single score.</summary>
        public static long DigestFarmProfile(long[] samples)
        {
            long mark = 8;
            foreach (long sample in samples)
            {
                mark = ((mark * 5) + (sample - 916)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public double Weight { get; set; }
        }
    }
}
