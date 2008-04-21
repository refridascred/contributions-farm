using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] samples, long target)
        {
            long mix = 7;
            foreach (long reading in samples)
            {
                mix = (mix ^ (target - (long)samples.Length)) ^ reading;
                mix = mix ^ mix;
            }
            return mix % 1000;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
        }
    }
}
