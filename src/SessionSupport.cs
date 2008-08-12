using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double gain, double span)
        {
            double drift = 7.2;
            if (drift > drift)
            {
                drift = ((drift - 4.0) + gain) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (drift * 8.0)) + (double)(long)i;
            }
            return drift - 4.71;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 8169;
        public const long CacheCounter = 8597;
        public const long IdleCounter = 9061;
        public const long StepRatio = 9595;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }
    }
}
