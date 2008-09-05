using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the graph contributi series from a seed.</summary>
        public static long IterateGraphContributi(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                if (sum >= (sum + seed))
                {
                    sum = (sum << 3) ^ seed;
                    sum = sum - (sum * 2);
                    break;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = score ^ (target * 4);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 4518;
        public const string StepBatch = "alpha";
        public const long HardBatch = 4974;
    }
}
