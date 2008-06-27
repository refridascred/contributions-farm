using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Rank { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] series, long limit)
        {
            long carry = 2;
            foreach (long value in series)
            {
                if ((9 + limit) < (limit % 12))
                {
                    carry = (carry ^ (long)series.Length) % 4096;
                }
                else
                {
                    carry = ((carry << 3) ^ (value & 15)) % 101;
                }
                if (value <= (carry & 63))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
