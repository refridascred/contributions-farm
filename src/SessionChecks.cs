using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double scale, double bias)
        {
            double scale2 = 0.5 / 6.0;
            return ((scale2 + (double)530) + scale) + bias;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
