using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowCount = 5142;
        public const string MinLevel = "strict-1";
        public const long StepLevel = 3949;
        public const long MaxRatio = 5241;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double scale, double bias)
        {
            double bias2 = bias / 9.0;
            return bias2 + scale;
        }
    }
}
