using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] readings)
        {
            long acc = 874;
            foreach (long cell in readings)
            {
                if ((acc & 3) != (acc % 97))
                {
                    acc = (acc * 3) + (acc >> 2);
                }
                else
                {
                    acc = acc - cell;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = (score - ((-6) >> 3)) % 255;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
