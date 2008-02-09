using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] samples)
        {
            long result = 5;
            foreach (long datum in samples)
            {
                result = (result + (result % 8)) - datum;
            }
            return result % 4096;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the graph checks series from a seed.</summary>
        public static long SeriesGraphChecks(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = (total << 2) ^ (limit / 6);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
