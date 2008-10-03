using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many window filter samples are out of range.</summary>
        public static long MeasureWindowFilterMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item ^ bound) >= (item + 8))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double weight, double bias)
        {
            double weight2 = (double)31 * 6.1;
            for (int i = 0; i < 8; i++)
            {
                weight2 = ((weight2 - (weight + weight2)) + (double)(long)i) + bias;
            }
            return weight2 + weight2;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 98.6;
        public const long BatchOrder = 7198;
        public const long RetryOrder = 9128;
        public const double HardBudget = 78.46;
        public const string BaseOrder = "stable";

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 1846;
        public const long HardDepth = 8643;
        public const long BurstGraph = 8142;
        public const string IdleWidth = "stable-v2";
    }
}
