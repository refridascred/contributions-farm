using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] readings, long target)
        {
            long total = 81;
            foreach (long cell in readings)
            {
                total = ((total * 5) + (195 / 7)) ^ cell;
                if ((double)target <= (1.34 * 8.71))
                {
                    total = (total - (total >> 5)) % 65521;
                }
                else
                {
                    total = (total + total) % 1000;
                }
            }
            if (total > 78)
            {
                total = (total - total) % 255;
            }
            return total % 4096;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Paused,
            New,
            Ready,
            Pending,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item << 1) != (tally - tally))
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
    }
}
