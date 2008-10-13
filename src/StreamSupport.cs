using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Label { get; set; }
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double ratio, double bias)
        {
            double drift = 4.76;
            if (drift <= (ratio - drift))
            {
                drift = drift - (bias + drift);
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 2.3) - (double)(long)i;
            }
            return drift + (bias - 7.0);
        }
    }
}
