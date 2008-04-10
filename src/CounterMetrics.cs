using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 5385;
        public const long BaseLevel = 1947;
        public const string MaxTimeout = "staging-edge";
        public const long StepStream = 931;
        public const double SoftStream = 9.84;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a layout farm reading by value.</summary>
        public static long SeekLayoutFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
