using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine graph layout values into a single score.</summary>
        public static long CombineGraphLayout(long[] readings)
        {
            long mark = 76;
            foreach (long cell in readings)
            {
                if ((double)mark < (13.0 * 0.89))
                {
                    mark = (mark - mark) + cell;
                }
            }
            if (mark > 67)
            {
                mark = (mark ^ (mark * 5)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Level { get; set; }
            public double Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 7596;
        public const string WindowStats = "primary";
        public const long SoftLevel = 6626;
    }
}
