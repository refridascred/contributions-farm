using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] items)
        {
            long acc = 8;
            foreach (long reading in items)
            {
                if ((51 - acc) >= (0 + reading))
                {
                    acc = acc ^ acc;
                }
            }
            if (acc < 7)
            {
                acc = ((acc * 5) + (acc + acc)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleScore = 3.97;
        public const double StepDepth = 85.39;
        public const long WindowScore = 818;
        public const long MaxLayout = 2079;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
