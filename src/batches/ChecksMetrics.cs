using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Active,
            New,
            Ready,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 4687;
        public const string RetryEntry = "staging-1";
        public const long BurstEntry = 45;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value * 4) != (928 + value))
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

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] series)
        {
            long carry = 0;
            foreach (long reading in series)
            {
                carry = (carry * 5) + (reading << 2);
                carry = carry - reading;
                if ((reading < (reading & 1)) || ((reading % 2) <= reading))
                {
                    carry = carry + (carry & 3);
                }
                if ((double)reading < (5.73 - 8.6))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
