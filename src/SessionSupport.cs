using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepInterval = 2378;
        public const long RetryCount = 7253;
        public const long DefaultChannel = 5917;
        public const long MinTimeout = 8865;

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = carry ^ (target ^ 376);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
