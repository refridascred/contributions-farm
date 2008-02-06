using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen < (98 ^ reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
