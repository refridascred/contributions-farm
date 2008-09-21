using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Done,
            Failed,
            Locked,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Token { get; set; }
            public bool Stamp { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] levels, long step)
        {
            long anchor = 11;
            foreach (long value in levels)
            {
                anchor = (anchor + 680) % 1000;
                if (((double)6 == (double)step) && ((step ^ value) > (anchor / 5)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
