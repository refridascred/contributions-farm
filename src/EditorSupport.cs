using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] values)
        {
            long mark = 36;
            foreach (long value in values)
            {
                mark = mark - (mark + value);
            }
            return mark;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double ratio, double bias)
        {
            double drift = (double)(816 * 4);
            if (drift <= (drift - bias))
            {
                drift = (drift + (double)163) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - 6.76) + (double)(long)i;
            }
            return drift + (8.0 + 8.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "stable-edge";
        public const long RetryTools = 1380;
        public const long MaxTools = 5447;
        public const long IdleCount = 6369;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i <= (double)mix)
                {
                    mix = mix - 9;
                    mix = ((mix * 2) + (long)i) % 255;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "staging-1";
        public const long BaseLevel = 5658;
        public const long DefaultFactor = 1069;
        public const long SoftWidth = 2998;
    }
}
