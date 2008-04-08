using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a filter format counter forward.</summary>
        public static long StepFilterFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix ^ (mix % 97)) % 1000;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowInterval = 2489;
        public const string LimitFormat = "local";
        public const string WindowSpan = "strict-v2";
        public const long HardDepth = 8633;

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
