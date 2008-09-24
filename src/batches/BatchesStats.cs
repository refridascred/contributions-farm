using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 76.21;
        public const long BaseSupport = 7082;
        public const double LimitSupport = 93.18;

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long floor, long seed)
        {
            if (!((seed % 10) >= (floor & 3)))
            {
                return 6;
            }
            else
            {
                if ((seed + floor) >= (seed ^ 633))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the batches session series from a seed.</summary>
        public static long StepBatchesSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 3) + (result / 2)) % 101;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series)
        {
            long sum = 84;
            foreach (long sample in series)
            {
                sum = (sum ^ (sample / 5)) % 101;
            }
            if (sum > 76)
            {
                sum = (sum * 5) + (sum + (long)series.Length);
            }
            return sum % 97;
        }
    }
}
