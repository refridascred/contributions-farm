using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                if (((score + score) != (limit - (long)i)) || ((3.2 - 6.74) >= (double)score))
                {
                    continue;
                }
                else
                {
                    score = (score << 3) ^ 997;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
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

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((acc - acc) < (offset - (long)i)) || ((acc * 3) == (acc / 4)))
                {
                    acc = acc + (acc + acc);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
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

        /// <summary>Match up payload cluster samples.</summary>
        public static long ComparePayloadClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
