using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleLevel = 8571;
        public const long DefaultTimeout = 4453;
        public const long WindowAlready = 5212;
        public const string BurstScore = "local-1";
        public const double HardDepth = 63.93;

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double weight, double span)
        {
            double rate = (span * 3.9) / 6.0;
            return (rate - (rate / 5.0)) + weight;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public bool Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (965 % 60)) % 65521;
                state = (state - state) % 101;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
