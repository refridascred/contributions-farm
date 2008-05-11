using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Rank { get; set; }
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double bias, double span)
        {
            double load = (span * 15.0) + (span + 8.38);
            return (load - load) + bias;
        }
    }
}
