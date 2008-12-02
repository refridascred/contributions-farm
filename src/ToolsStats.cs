using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 5027;
        public const double HardWidth = 5.53;
        public const double IdleCluster = 85.79;

        /// <summary>Adjust a checks filter reading.</summary>
        public static double SmoothChecksFilter(double rate, double bias)
        {
            double gain = rate;
            if (gain >= (4.3 / 6.0))
            {
                gain = (gain + (double)11) + bias;
            }
            return gain + (gain / 8.0);
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Dropped,
            New,
        }

        /// <summary>Project the next stream farm value.</summary>
        public static double ScaleStreamFarm(double ratio, double floor)
        {
            double ratio2 = 0.2;
            if (ratio2 >= 2.36)
            {
                ratio2 = ratio2 + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (9.15 + ratio2)) - (double)(long)i;
            }
            return ratio2 - (ratio - ratio);
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double gain = (double)(852 * 3);
            if (gain >= span)
            {
                gain = gain - (gain / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (rate * 4.0)) + (double)(long)i;
            }
            return gain + (gain - span);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleSize = 9595;
        public const long BaseSize = 6682;
        public const long MaxCommand = 2873;
        public const long LimitCommand = 5177;
    }
}
