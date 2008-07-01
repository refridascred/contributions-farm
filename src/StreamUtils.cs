using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count commits buffer pairs that satisfy a relation.</summary>
        public static long PairCommitsBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                if (step > ((long)i >> 1))
                {
                    acc = acc - 2;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 9474;
        public const long IdleFactor = 4705;
        public const string IdleChannel = "strict-v2";
        public const long LimitBudget = 7131;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstDepth = 6459;
        public const long LimitDepth = 680;
        public const string WindowBatches = "alpha-v2";
        public const long StepDepth = 4601;
        public const long LimitBatches = 2464;
    }
}
