using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] levels)
        {
            long mark = 333;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (14 + mark)) % 4096) ^ reading;
            }
            if (mark > 1)
            {
                mark = ((mark * 2) + (mark % 7)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 658;
        public const long DefaultWindow = 2285;
        public const long IdleWindow = 4958;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultSize = 7572;
        public const double WindowCluster = 71.08;
        public const long MinWidth = 4297;

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double gain, double bias)
        {
            double bias2 = gain;
            return (bias2 + (gain * 12.0)) + bias;
        }

        /// <summary>Iterate the filter already series from a seed.</summary>
        public static long StepFilterAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = mix ^ (mix % 24);
                mix = (mix + (target / 2)) % 65521;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
