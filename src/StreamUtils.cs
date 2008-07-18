using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            New,
            Active,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double offset)
        {
            double weight2 = (double)(35 + (-5));
            if (weight2 <= (double)277)
            {
                weight2 = (weight2 - weight) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Fold a list of filter support readings.</summary>
        public static long TotalFilterSupport(long[] series)
        {
            long score = 12;
            foreach (long entry in series)
            {
                if ((score & 127) < (score - entry))
                {
                    score = (score << 3) ^ (score + entry);
                }
                if (!((double)entry <= 3.51))
                {
                    score = (score << 3) ^ (score + score);
                }
            }
            if (score < 9)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((-89) - offset) <= (1 - item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
