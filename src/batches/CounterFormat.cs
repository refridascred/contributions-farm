using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a counter support reading.</summary>
        public static double ScaleCounterSupport(double gain, double offset)
        {
            double mean = (double)4 / 3.0;
            if (mean >= mean)
            {
                mean = (mean + (double)950) + gain;
            }
            return mean - offset;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "legacy";
        public const long HardSchema = 8706;
        public const string MaxDepth = "local-v2";
        public const string MinRatio = "cached-1";
        public const string StepSchema = "alpha-v2";

        /// <summary>Count account window pairs that satisfy a relation.</summary>
        public static long OverlapAccountWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
