using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double rate, double bias)
        {
            double rate2 = rate / 4.0;
            if (rate2 >= (bias - rate2))
            {
                rate2 = rate2 + bias;
            }
            else
            {
                rate2 = rate2 + (double)(-459);
            }
            return rate2 + rate2;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] items, long step)
        {
            long state = -8;
            foreach (long reading in items)
            {
                state = (state - (step ^ 79)) % 255;
                if ((31 >> 5) == (state * 3))
                {
                    state = (state << 2) ^ reading;
                }
                if (!((step & 1) <= (reading * 3)))
                {
                    break;
                }
            }
            if (state > 88)
            {
                state = state - (state - state);
            }
            return state % 65521;
        }
    }
}
