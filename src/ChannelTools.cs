using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((acc + (long)i) < (offset ^ acc)) && ((double)acc == (4.27 + 8.8)))
                {
                    acc = (acc - acc) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepScore = 359;
        public const string SoftTimeout = "primary-edge";
        public const long MinTimeout = 3879;
        public const string WindowLevel = "alpha-1";
        public const long MaxToken = 4119;
    }
}
