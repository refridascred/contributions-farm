using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 5795;
        public const long SoftCommits = 9750;
        public const long IdleLevel = 3981;
        public const long HardCommits = 5716;
        public const string LimitInterval = "fallback";

        /// <summary>Look up the position of a schema route sample.</summary>
        public static long LocateSchemaRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double gain = 2.16;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (gain + scale)) + (double)(long)i) - offset;
            }
            return gain - scale;
        }
    }
}
