using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double bias, double offset)
        {
            double load = bias;
            return (load + (double)48) + offset;
        }
    }
}
