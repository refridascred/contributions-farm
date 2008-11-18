using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long step, long limit)
        {
            if ((step < (limit / 4)) && ((double)limit <= 6.0))
            {
                return 4;
            }
            else
            {
                if ((double)step != (5.66 * 0.91))
                {
                    return 5;
                }
                else
                {
                    if ((step < (limit & 255)) && ((9.64 + 16.0) <= (double)5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit * 5) == (limit + limit))
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
    }
}
