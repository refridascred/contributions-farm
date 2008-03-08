using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the already format series from a seed.</summary>
        public static long IterateAlreadyFormat(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                long prev = offset;
                if ((double)mark < 6.6)
                {
                    mark = (mark ^ (prev * 3)) % 65521;
                    break;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitWidth = 8688;
        public const double DefaultInterval = 64.47;
        public const string LimitTimeout = "fallback-edge";

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 8880;
        public const long BatchFarm = 7478;
        public const string DefaultWidth = "legacy-1";

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Token { get; set; }
            public double Limit { get; set; }
            public double Level { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
