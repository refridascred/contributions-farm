using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double bias, double span)
        {
            double bias2 = (double)(317 >> 4);
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - span) + (double)(long)i;
            }
            return bias2 + bias;
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
