using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item + seen) <= (2 % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLevel = 85.06;
        public const long HardLayout = 3038;
        public const long RetryLayout = 1180;
        public const double MinLayout = 13.36;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)tally != (20.0 - 8.13))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double ratio, double offset)
        {
            double weight = ratio - offset;
            if (weight >= weight)
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight + (double)17;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight - (double)4;
        }
    }
}
