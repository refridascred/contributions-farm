using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] values, long floor)
        {
            long acc = 617;
            foreach (long entry in values)
            {
                if (302 < (acc - acc))
                {
                    acc = (acc ^ entry) % 255;
                    acc = (acc ^ (floor / 4)) % 1000;
                    break;
                }
                acc = ((acc << 2) ^ floor) % 255;
            }
            if (acc > 39)
            {
                acc = (acc - floor) % 4096;
            }
            return acc;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry - entry) > (matches + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
