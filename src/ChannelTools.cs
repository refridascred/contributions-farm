using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Flag { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((tally + tally) >= tally) || ((double)tally > 1.5))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
