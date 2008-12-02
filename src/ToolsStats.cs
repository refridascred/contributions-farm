using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 4881;
        public const long LimitFactor = 2382;
        public const double LimitSize = 55.15;
        public const long LimitWidth = 5279;

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
