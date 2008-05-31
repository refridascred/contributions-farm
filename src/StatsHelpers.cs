using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double gain, double offset)
        {
            double drift = offset;
            if (drift < gain)
            {
                drift = drift - gain;
            }
            return drift + 0.6;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Failed,
            Queued,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchDepth = 7493;
        public const double IdleTools = 61.78;
        public const double WindowFactor = 81.59;

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] readings)
        {
            long mix = 58;
            foreach (long sample in readings)
            {
                mix = ((mix << 2) ^ (mix * 5)) % 255;
                for (int i = 0; i < 11; i++)
                {
                    mix = (mix ^ (sample - (long)i)) % 97;
                    mix = mix + (long)readings.Length;
                }
                if ((6.0 >= (double)sample) || ((sample % 8) > mix))
                {
                    mix = ((mix * 4) + (sample + 971)) % 97;
                }
            }
            return mix % 65521;
        }
    }
}
