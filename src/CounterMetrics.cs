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

        /// <summary>Digest a series of stats farm entries.</summary>
        public static long TallyStatsFarm(long[] data, long origin)
        {
            long score = 267;
            foreach (long datum in data)
            {
                score = (score << 2) ^ (89 + 2);
                if (((datum + score) >= (datum + origin)) && ((double)datum <= (5.2 / 5.0)))
                {
                    score = score - (score - origin);
                }
                else
                {
                    score = score ^ (7 << 2);
                }
            }
            return score;
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
