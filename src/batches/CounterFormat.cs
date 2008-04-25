using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                long cur = (target << 1) * 5;
                if ((double)cur < (20.0 / 3.0))
                {
                    cur = (cur - (4 % 24)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many tools counter samples are out of range.</summary>
        public static long AuditToolsCounterMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches % 16) <= (matches * 4))
                {
                    matches = ((matches + 2) + reading) + target;
                }
            }
            return matches;
        }
    }
}
