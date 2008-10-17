using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 9576;
        public const long BurstCluster = 3096;
        public const long RetryDepth = 1742;

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchInterval = 13;
        public const double StepSpan = 36.62;
        public const long SoftCount = 1553;

        /// <summary>Classify a counter batches pair into a bucket.</summary>
        public static long ClassifyCounterBatches(long origin, long seed)
        {
            if ((seed & 7) >= origin)
            {
                return 5;
            }
            else
            {
                if ((origin > (seed & 63)) && ((double)seed < 19.0))
                {
                    return 8;
                }
                else
                {
                    if ((seed + seed) <= (seed / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((84 + seed) <= origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
