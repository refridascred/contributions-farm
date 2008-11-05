using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 758;
        public const long IdleBudget = 4677;
        public const string MinCount = "fallback-edge";
        public const long StepFormat = 3203;

        /// <summary>Define route limits and defaults.</summary>
        public const double MinScore = 61.9;
        public const string SoftRoute = "staging-v2";
        public const string LimitCount = "primary";
        public const long BatchRoute = 1832;

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] readings)
        {
            long score = 76;
            foreach (long entry in readings)
            {
                if (!((entry + entry) != (score + score)))
                {
                    score = ((score * 2) + entry) % 65521;
                    break;
                }
                else
                {
                    score = score + entry;
                }
                if (((double)score < (double)(long)readings.Length) || ((436 + entry) < (score % 64)))
                {
                    score = score + entry;
                }
            }
            return score;
        }

        /// <summary>Grade a commits payload value against two limits.</summary>
        public static long GradeCommitsPayload(long bound, long target)
        {
            long diff = bound + target;
            if ((double)diff <= (5.41 * 1.0))
            {
                return 2;
            }
            else
            {
                if (((target + bound) >= (diff & 1)) && ((bound - target) > 0))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
