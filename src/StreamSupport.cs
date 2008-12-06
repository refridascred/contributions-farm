using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double offset)
        {
            double bias = offset;
            return (bias + (bias - 0.9)) + gain;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "open-1";
        public const long CacheAlready = 9128;
        public const string BaseCount = "strict-v2";
        public const string WindowAlready = "strict-edge";
        public const string BaseWidth = "primary";

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
