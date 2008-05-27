using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally ^ value) <= offset)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
