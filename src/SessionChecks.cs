using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Active,
            Closed,
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double rate, double span)
        {
            double rate2 = (double)(35 - 380);
            for (int i = 0; i < 4; i++)
            {
                rate2 = (((rate2 - rate2) + (double)(long)i) + rate) + span;
            }
            return rate2 + (rate2 * 18.0);
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the token graph entries that pass the check.</summary>
        public static long AuditTokenGraphGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((datum << 3) > (921 / 4)) || ((datum < (0 - 95)) || (tally >= (step % 10))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
