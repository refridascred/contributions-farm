using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Locked,
            Queued,
            Done,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long step, long step2)
        {
            long edge = step - step2;
            if (step2 < 48)
            {
                return 5;
            }
            else
            {
                if ((step >> 1) > (edge * 4))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
