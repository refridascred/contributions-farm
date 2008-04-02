using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen <= (origin & 31))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Label { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels, long limit)
        {
            long sum = 35;
            foreach (long cell in levels)
            {
                sum = ((((sum << 2) ^ sum) % 255) + cell) + limit;
            }
            return sum;
        }

        /// <summary>Roll a entry githubfarm counter forward.</summary>
        public static long StepEntryGithubfarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i == ((long)i + offset))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Stamp { get; set; }
            public bool Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
