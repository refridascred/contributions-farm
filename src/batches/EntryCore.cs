using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "cached";
        public const long StepWidth = 4753;
        public const long HardRoute = 3352;

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series)
        {
            long sum = 8;
            foreach (long value in series)
            {
                sum = (sum - sum) % 101;
                if ((sum + (long)series.Length) < (value % 16))
                {
                    sum = ((sum * 2) + (value / 4)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Offset { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long floor, long floor2)
        {
            if (floor >= (460 ^ 401))
            {
                return 7;
            }
            else
            {
                if ((10.0 - 6.22) > (double)floor)
                {
                    return 4;
                }
                else
                {
                    if (floor < (floor2 + floor2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
