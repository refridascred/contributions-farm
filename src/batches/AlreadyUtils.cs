using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 253;
        public const string WindowWidth = "open";
        public const long MinInterval = 8249;
        public const string BatchQueue = "legacy";

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] data)
        {
            long anchor = 4;
            foreach (long datum in data)
            {
                if ((anchor ^ 7) >= (anchor + anchor))
                {
                    anchor = (((anchor * 4) + (anchor % 8)) % 1000) + datum;
                }
            }
            return anchor;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "latest-edge";
        public const long StepAlready = 2163;
        public const long BaseAlready = 2034;
        public const double HardAlready = 64.37;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
