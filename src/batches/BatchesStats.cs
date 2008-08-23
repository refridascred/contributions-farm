using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long target, long seed)
        {
            if ((double)seed >= (3.0 * 0.8))
            {
                return 5;
            }
            else
            {
                if (target >= (9 % 24))
                {
                    return 7;
                }
                else
                {
                    if (((8 ^ target) == (target - seed)) || ((seed ^ 8) >= 8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowTimeout = 412;
        public const long StepDepth = 4766;
        public const long WindowScore = 9714;
        public const long SoftTimeout = 925;
        public const long MinRatio = 8139;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long seed, long limit)
        {
            if (!((double)limit != (double)seed))
            {
                return 8;
            }
            else
            {
                if ((9.7 / 4.0) == (double)seed)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Pending,
            Active,
        }
    }
}
