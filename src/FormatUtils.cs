using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double bias, double floor)
        {
            double weight = (double)(9 >> 5);
            if (weight <= bias)
            {
                weight = weight + (double)763;
            }
            else
            {
                weight = weight - (floor - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (4.1 / 8.0)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already account samples are out of range.</summary>
        public static long MeasureAlreadyAccountOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + matches) == (sample ^ matches))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Offset { get; set; }
            public bool Region { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
