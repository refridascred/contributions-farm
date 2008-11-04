using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] data)
        {
            long anchor = 26;
            foreach (long cell in data)
            {
                if (!(anchor > (cell + anchor)))
                {
                    anchor = ((anchor * 2) + (5 * 4)) % 97;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 8455;
        public const double CacheAlready = 35.9;
        public const long DefaultAlready = 6298;
    }
}
