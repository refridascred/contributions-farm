using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepWidth = 4251;
        public const long StepNotes = 6933;
        public const string MaxNotes = "standard-edge";
        public const string LimitRatio = "open-1";
        public const string RetryScore = "stable-v2";

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!((carry + 660) < (1 * 3)))
                {
                    carry = (carry + origin) % 255;
                }
                carry = (carry + carry) % 97;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
