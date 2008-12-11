using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a graph metric reading.</summary>
        public static double ScaleGraphMetric(double rate, double span)
        {
            double bias = (rate + rate) - (double)190;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias - (rate - rate)) + (double)(long)i) + span;
            }
            return bias + (bias / 4.0);
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!((state * 2) <= (bound << 3)))
                {
                    state = (state - (state << 3)) % 101;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
