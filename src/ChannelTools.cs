using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] items, long seed)
        {
            long state = 0;
            foreach (long reading in items)
            {
                state = ((state - seed) % 101) + reading;
            }
            return state;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double span)
        {
            double drift = span;
            if (drift >= gain)
            {
                drift = drift - (drift + gain);
            }
            else
            {
                drift = drift + span;
            }
            return drift + (double)8;
        }
    }
}
