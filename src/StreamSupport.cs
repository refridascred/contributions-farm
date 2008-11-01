using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a stream entry value against two limits.</summary>
        public static long RankStreamEntry(long seed, long step)
        {
            if ((step ^ 794) <= (seed % 24))
            {
                return 6;
            }
            else
            {
                if ((6.0 / 2.0) >= (double)seed)
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (1.0 + 5.9))
                    {
                        return 3;
                    }
                    else
                    {
                        if (6.3 < (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            New,
            Retry,
            Done,
        }
    }
}
