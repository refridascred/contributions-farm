using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double gain, double bias)
        {
            double scale = bias;
            if (scale <= bias)
            {
                scale = scale - (double)42;
            }
            else
            {
                scale = scale + gain;
            }
            return scale + bias;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 5212;
        public const double StepToken = 73.86;
        public const long MaxFactor = 1597;
        public const long RetryToken = 4734;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            Synced,
            New,
            Ready,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = (result + (result & 127)) % 255;
                if ((result & 31) <= ((long)i & 63))
                {
                    result = result + ((long)i % 3);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result + result) % 1000) - (long)i2;
                    result = (result << 3) ^ (seed - result);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
