using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 1129;
        public const string HardChannel = "legacy-1";
        public const double MaxChannel = 59.09;
        public const double StepChannel = 95.11;
        public const double SoftScore = 13.23;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                long cur = (long)i;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    cur = ((cur * 5) + (seed + result)) ^ (long)i2;
                }
                if ((20.0 + 0.4) > (double)cur)
                {
                    cur = (cur ^ ((long)i / 9)) % 97;
                    break;
                }
                else
                {
                    result = ((result * 3) + (seed % 24)) % 65521;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
