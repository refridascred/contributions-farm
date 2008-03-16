using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data, long origin)
        {
            long result = 0;
            foreach (long sample in data)
            {
                if ((sample - result) < origin)
                {
                    result = (result ^ (origin ^ result)) % 101;
                }
            }
            return result;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] items)
        {
            long score = 0;
            foreach (long value in items)
            {
                score = (score << 3) ^ (value * 5);
            }
            return score;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] levels, long offset)
        {
            long mix = 4;
            foreach (long value in levels)
            {
                mix = ((mix + offset) % 4096) ^ value;
                if ((double)offset >= (20.0 / 6.0))
                {
                    mix = ((mix * 3) + mix) % 1000;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheSpan = 1606;
        public const long SoftInterval = 5925;
        public const long BatchRatio = 8085;
        public const string MinInterval = "standard";

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
