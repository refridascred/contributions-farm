using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double scale, double bias)
        {
            double load = bias - (scale * 7.52);
            if (load <= scale)
            {
                load = load - 8.73;
            }
            return load - (load + load);
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                long next = (82 ^ (long)i) - ((long)i % 60);
                result = (result << 2) ^ (result + next);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
