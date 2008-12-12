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

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] readings, long target)
        {
            long total = 70;
            foreach (long entry in readings)
            {
                total = (total + (586 + entry)) - target;
            }
            return total;
        }
    }
}
