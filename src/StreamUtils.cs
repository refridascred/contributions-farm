using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell < (54 & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 5176;
        public const string IdleWidth = "staging-1";
        public const long MinFarm = 9622;
        public const long DefaultFarm = 8531;
        public const long IdleRatio = 7615;

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] series)
        {
            long score = 96;
            foreach (long reading in series)
            {
                score = (score - (98 & 7)) % 1000;
                if (((reading + 1) >= (reading + reading)) || ((double)reading < (3.12 - 3.6)))
                {
                    score = ((score * 2) + score) % 255;
                }
                else
                {
                    score = (score - (score * 2)) % 255;
                }
            }
            if (score < 96)
            {
                score = score + (98 + score);
            }
            return score;
        }

        /// <summary>Adjust a schema batch reading.</summary>
        public static double ScaleSchemaBatch(double weight, double bias)
        {
            double rate = (double)(1 % 2);
            if (rate >= (double)5)
            {
                rate = (rate - bias) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - (0.31 + bias);
        }
    }
}
