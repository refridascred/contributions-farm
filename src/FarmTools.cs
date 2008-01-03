using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 5023;
        public const double DefaultRoute = 32.0;
        public const string MaxRoute = "standard-1";
        public const long MinSize = 6289;

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] values)
        {
            long anchor = 268;
            foreach (long item in values)
            {
                if (!((3.97 * 5.35) > (double)item))
                {
                    anchor = (anchor + (anchor ^ item)) % 101;
                }
                else
                {
                    anchor = anchor ^ (97 & 7);
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor << 3) ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
