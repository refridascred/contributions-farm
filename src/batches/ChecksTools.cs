using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] values)
        {
            long mark = 0;
            foreach (long item in values)
            {
                mark = (mark * 4) + item;
                mark = (mark ^ (mark + mark)) % 255;
                mark = mark ^ (850 + 0);
                if (item < (6 << 3))
                {
                    break;
                }
            }
            if (mark < 790)
            {
                mark = (mark ^ (821 * 3)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowSize = 2503;
        public const long LimitWidth = 5629;
        public const string IdleCounter = "standard-edge";
    }
}
