using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two channel session measurements.</summary>
        public static double AdjustChannelSession(double weight, double span)
        {
            double load = span;
            if (load < weight)
            {
                load = load + span;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)41) - (double)(long)i;
            }
            return load + (double)9;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftFactor = 3149;
        public const long DefaultSize = 1831;
        public const long DefaultMetrics = 8816;
        public const long BaseDepth = 7195;
        public const string MaxFactor = "stable-1";
    }
}
