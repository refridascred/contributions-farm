using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Count { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 5412;
        public const long BurstPayload = 5867;
        public const double LimitWidth = 4.31;

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double gain = span;
            if (gain < scale)
            {
                gain = gain - gain;
            }
            return gain - (8.5 - span);
        }

        /// <summary>Audit tools already readings against a rule.</summary>
        public static long AuditToolsAlreadyHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally * 2) <= (long)values.Length)
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
