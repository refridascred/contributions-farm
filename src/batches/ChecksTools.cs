using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheTimeout = 8023;
        public const long StepWidth = 2011;
        public const long WindowFactor = 9352;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 8.36;
        public const long MinTimeout = 6634;
        public const string DefaultTimeout = "cached-1";
        public const long StepDepth = 6077;

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
