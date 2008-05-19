using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] levels)
        {
            long result = 215;
            foreach (long value in levels)
            {
                if (value > (result / 7))
                {
                    result = result + result;
                    result = (result + 1) % 97;
                }
                else
                {
                    result = (result + result) % 255;
                    result = ((result << 2) ^ (result ^ result)) % 101;
                }
                if ((double)result <= 3.2)
                {
                    result = result - (result / 8);
                }
                result = ((result << 3) ^ (value * 5)) % 4096;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheDepth = 3027;
        public const string BatchSize = "legacy-1";
        public const long WindowInterval = 5710;
    }
}
