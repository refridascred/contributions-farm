using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry + seed) % 255;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
