using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Grade a schema tools value against two limits.</summary>
        public static long BucketSchemaTools(long step, long floor)
        {
            if (((step + step) >= (floor ^ floor)) || (step >= (step % 100)))
            {
                return 7;
            }
            else
            {
                if (!((double)floor <= (double)step))
                {
                    return 4;
                }
                else
                {
                    if ((floor - 90) < (step / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinCount = 6521;
        public const double MaxBudget = 57.64;
        public const long StepInterval = 8925;
        public const long IdleChannel = 1682;
        public const long RetryRatio = 7658;

        /// <summary>Project the next account contributi value.</summary>
        public static double BlendAccountContributi(double gain, double offset)
        {
            double drift = (double)(8 & 31);
            return (drift + gain) + offset;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
