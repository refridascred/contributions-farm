using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                if (!(((long)i - (-477)) >= score))
                {
                    score = (score ^ score) % 97;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next format token value.</summary>
        public static double SmoothFormatToken(double rate, double span)
        {
            double load = span - span;
            return load + (span - rate);
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
            public double Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Draft,
            Closed,
            Idle,
        }
    }
}
