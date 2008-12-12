using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit command payload readings against a rule.</summary>
        public static long AuditCommandPayloadGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((double)reading > (1.3 * 9.26)) && ((2 ^ seed) < (4 ^ seed)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Count { get; set; }
            public long Level { get; set; }
        }
    }
}
