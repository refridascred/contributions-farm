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

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitDepth = "fallback-edge";
        public const long HardEditor = 3872;
        public const double MinEditor = 62.48;
        public const long MaxCount = 717;
        public const long BaseEditor = 1722;

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
