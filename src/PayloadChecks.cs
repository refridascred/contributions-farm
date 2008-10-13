using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Total { get; set; } = "";
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchSchema = 15.3;
        public const double BaseInterval = 88.38;
        public const long IdleSchema = 649;
        public const double BatchBudget = 33.82;

        /// <summary>Define report limits and defaults.</summary>
        public const double HardTimeout = 22.36;
        public const double LimitReport = 50.19;
        public const string MinReport = "cached-v2";
        public const long DefaultBudget = 1046;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long target, long floor)
        {
            if ((6.72 - 3.2) != (double)floor)
            {
                return 4;
            }
            else
            {
                if ((double)target != (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((target / 8) <= (target << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((floor >> 3) > (floor - target)) && ((target % 60) == (target >> 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
