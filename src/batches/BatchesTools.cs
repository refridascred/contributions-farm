using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 2499;
        public const string IdleRatio = "fallback-1";
        public const long IdleContext = 9852;
        public const long RetryTimeout = 5172;
        public const long BurstContext = 8843;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long origin)
        {
            long step = bound ^ origin;
            if ((bound / 4) > step)
            {
                return 5;
            }
            else
            {
                if ((bound + bound) < 835)
                {
                    return 7;
                }
                else
                {
                    if (!(origin > (step % 12)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSize = 2619;
        public const double StepTimeout = 98.31;
        public const long RetryStream = 5443;
    }
}
