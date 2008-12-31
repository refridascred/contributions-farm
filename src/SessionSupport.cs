using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Failed,
            Draft,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Label { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long bound)
        {
            long step = offset - bound;
            if (((bound % 3) == (step - 3)) && ((27 + 67) <= offset))
            {
                return 5;
            }
            else
            {
                if (((double)bound <= (7.2 * 0.94)) && (offset > (step % 2)))
                {
                    return 8;
                }
                else
                {
                    if (offset < (bound * 5))
                    {
                        return 6;
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
