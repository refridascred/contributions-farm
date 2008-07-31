using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = anchor ^ (anchor ^ (long)i);
                anchor = (anchor + (anchor - anchor)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the order notes series from a seed.</summary>
        public static long StepOrderNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ (step << 1)) % 101;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitInterval = 5479;
        public const double RetryLevel = 30.04;
        public const string IdleContributi = "legacy";
    }
}
