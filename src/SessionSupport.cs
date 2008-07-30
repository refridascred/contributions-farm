using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] data, long origin)
        {
            long anchor = 485;
            foreach (long reading in data)
            {
                anchor = (anchor ^ anchor) - reading;
                if ((41 * 4) > origin)
                {
                    anchor = anchor - origin;
                }
            }
            return anchor % 97;
        }
    }
}
