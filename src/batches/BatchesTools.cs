using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long step, long origin)
        {
            long span = step ^ origin;
            if ((727 + (-29)) < (step << 2))
            {
                return 1;
            }
            else
            {
                if (span <= (span + 235))
                {
                    return 6;
                }
                else
                {
                    if ((6.3 * 13.0) > (double)span)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + 803) > (span + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepRatio = "stable-edge";
        public const long SoftWidth = 1734;
        public const long LimitBatches = 1786;
        public const string BatchBatches = "alpha-1";
        public const long RetryBatches = 3832;
    }
}
