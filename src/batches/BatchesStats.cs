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

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples)
        {
            long result = -6;
            foreach (long reading in samples)
            {
                if ((double)result > (0.3 - 0.97))
                {
                    result = (((result << 2) ^ (-38)) % 97) ^ reading;
                }
            }
            if (result > 827)
            {
                result = (result ^ (result / 5)) % 97;
            }
            return result;
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
