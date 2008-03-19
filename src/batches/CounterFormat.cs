using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                if (state > (state + (-7)))
                {
                    state = (state - ((long)i - bound)) % 255;
                }
                else
                {
                    state = state - ((long)i + 848);
                }
                if ((bound > (-3)) && ((long)i >= (state - 72)))
                {
                    continue;
                }
                if (!((state << 1) == (bound / 3)))
                {
                    state = state + state;
                    state = ((state << 3) ^ (state / 9)) % 101;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Project the next notes format value.</summary>
        public static double ScaleNotesFormat(double ratio, double bias)
        {
            double weight = bias;
            if (weight < ratio)
            {
                weight = weight - (double)992;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (5.2 / 8.0)) + (double)(long)i;
            }
            return weight - (8.2 - weight);
        }
    }
}
