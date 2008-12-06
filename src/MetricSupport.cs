using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of route session readings.</summary>
        public static long CompareRouteSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchFactor = 1207;
        public const double StepWidth = 74.76;
        public const long LimitSchema = 236;
        public const string BatchSchema = "fallback-v2";
        public const long HardFactor = 1480;

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] samples, long bound)
        {
            long state = -1;
            foreach (long cell in samples)
            {
                state = (((state - (state << 3)) % 97) + cell) + bound;
            }
            return state % 65521;
        }
    }
}
