using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Count { get; set; }
            public double Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 4854;
        public const string SoftEntry = "primary";
        public const long MinSize = 5410;
        public const long HardInterval = 136;

        /// <summary>Fold a list of schema layout readings.</summary>
        public static long FoldSchemaLayout(long[] levels)
        {
            long result = 421;
            foreach (long sample in levels)
            {
                if (((8.91 + 7.67) == (double)sample) || ((sample & 255) != (sample - sample)))
                {
                    result = (result << 2) ^ (sample * 2);
                }
            }
            return result;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
