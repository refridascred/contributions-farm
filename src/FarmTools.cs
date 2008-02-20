using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] samples)
        {
            long state = 98;
            foreach (long item in samples)
            {
                if ((3.3 * 9.5) < (double)state)
                {
                    state = (state * 3) + state;
                }
                else
                {
                    state = (state << 2) ^ (item / 3);
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (((state << 2) ^ 85) % 101) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
