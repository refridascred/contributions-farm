using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit route queue readings against a rule.</summary>
        public static long TallyRouteQueueHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches + matches) >= (310 - reading))
                {
                    matches = (matches + 2) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }
    }
}
