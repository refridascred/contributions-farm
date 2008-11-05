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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (target >= (reading & 1))
                {
                    count = count + 1;
                }
            }
            return count;
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
