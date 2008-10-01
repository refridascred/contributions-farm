using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] series)
        {
            long sum = -95;
            foreach (long entry in series)
            {
                if ((sum - 5) < (entry - sum))
                {
                    sum = (sum + (sum + sum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "standard";
        public const long RetryStats = 5907;
        public const long MaxStats = 8577;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Offset { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
