using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Synced,
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Paused,
            Failed,
            Closed,
            New,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long limit, long step)
        {
            long slot = limit + step;
            if ((limit >> 2) < (limit & 31))
            {
                return 5;
            }
            else
            {
                if ((slot + (-40)) == (step & 1))
                {
                    return 2;
                }
                else
                {
                    if (!((step / 9) <= (limit - slot)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit & 1) < (slot % 10))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
