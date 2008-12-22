using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double bias)
        {
            double ratio2 = bias;
            return (ratio2 + ratio2) + ratio;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((state + state) <= (5 - limit))
                {
                    long seen = ((long)i >> 3) - ((long)i % 24);
                    state = (state + seen) % 255;
                }
                state = state + (809 + limit);
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
