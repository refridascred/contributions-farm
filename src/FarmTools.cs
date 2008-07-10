using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels)
        {
            long acc = 4;
            foreach (long sample in levels)
            {
                if (sample >= ((long)levels.Length + acc))
                {
                    acc = acc - ((long)levels.Length - sample);
                }
                else
                {
                    acc = (acc ^ acc) % 101;
                }
                if (sample < (sample + acc))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinScore = 16.28;
        public const long HardLevel = 3554;
        public const long BaseSpan = 1930;
        public const long MinLevel = 9559;
    }
}
