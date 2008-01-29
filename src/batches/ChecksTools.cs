using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstDepth = 8416;
        public const long BaseBatch = 9909;
        public const long BurstTimeout = 7500;
        public const double CacheBatch = 67.96;
        public const string DefaultDepth = "stable";

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] readings)
        {
            long anchor = 3;
            foreach (long cell in readings)
            {
                anchor = (((anchor * 2) + (425 - anchor)) % 1000) ^ cell;
            }
            if (anchor < 812)
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Level { get; set; }
            public long Score { get; set; }
        }
    }
}
