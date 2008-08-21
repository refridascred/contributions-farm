using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next profile token value from a seed.</summary>
        public static long RollProfileToken(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((state - limit) < (limit + limit))
                {
                    state = ((state << 3) ^ (112 + limit)) % 4096;
                }
                state = (state - limit) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Owner { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
