using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftTimeout = 2614;
        public const long WindowTimeout = 6392;
        public const long SoftRoute = 4519;
        public const long StepRoute = 6482;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long target, long limit)
        {
            if (((limit % 12) <= (target + limit)) && ((target - 4) > (limit / 5)))
            {
                return 3;
            }
            else
            {
                if ((target + 468) <= 527)
                {
                    return 7;
                }
                else
                {
                    if (!((limit + limit) != (target >> 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit <= (target - target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }
    }
}
