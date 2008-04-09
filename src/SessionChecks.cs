using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next payload order value.</summary>
        public static double ScalePayloadOrder(double weight, double bias)
        {
            double weight2 = (bias - weight) / 7.0;
            return weight2 - (bias - bias);
        }

        /// <summary>Roll a graph route counter forward.</summary>
        public static long IterateGraphRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = (state << 3) ^ (offset % 97);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseDepth = 1387;
        public const long BurstRatio = 5516;
        public const long SoftInterval = 3499;
        public const string MinFilter = "alpha-v2";
    }
}
