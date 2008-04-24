using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a context metrics pair into a bucket.</summary>
        public static long ClassifyContextMetrics(long seed, long step)
        {
            if (((double)seed > 5.26) && ((16.0 + 9.04) == (double)seed))
            {
                return 8;
            }
            else
            {
                if (step <= (seed ^ step))
                {
                    return 5;
                }
                else
                {
                    if ((seed % 7) <= (step ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 8258;
        public const long SoftMetric = 9257;
        public const long MinTimeout = 928;
        public const long MinMetric = 3840;
    }
}
