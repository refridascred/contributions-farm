using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Locked,
            Retry,
            New,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long floor, long target)
        {
            if ((floor * 5) >= (target / 5))
            {
                return 7;
            }
            else
            {
                if (floor >= (floor + target))
                {
                    return 4;
                }
                else
                {
                    if (floor >= (floor ^ target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
