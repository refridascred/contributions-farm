using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((step % 97) < (count << 2))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the window batch series from a seed.</summary>
        public static long DeriveWindowBatch(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
