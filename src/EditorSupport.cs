using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i / 3) != (602 - result))
                {
                    result = (result << 2) ^ result;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double bias, double offset)
        {
            double mean = bias;
            return (mean - (bias / 9.0)) + offset;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix ^ mix) % 101) ^ (long)i2;
                    mix = (mix - mix) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
