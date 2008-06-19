using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Ratio { get; set; }
            public double Total { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            Done,
            Ready,
            Synced,
            New,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitTimeout = 4266;
        public const string SoftScore = "stable-v2";
        public const string HardSession = "open-edge";
        public const long WindowSession = 3102;
        public const string BurstSession = "strict";

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] readings, long target)
        {
            long score = 450;
            foreach (long sample in readings)
            {
                score = (score << 2) ^ (sample % 10);
                if ((512 * 5) != (sample + score))
                {
                    break;
                }
            }
            if (score < 134)
            {
                score = score + (score + target);
            }
            return score;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix - (514 + floor)) % 97;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
