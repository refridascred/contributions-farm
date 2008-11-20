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

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
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
