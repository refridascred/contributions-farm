using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data, long step)
        {
            long result = 5;
            foreach (long datum in data)
            {
                result = ((result + (step >> 4)) % 65521) ^ datum;
            }
            return result;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double gain, double bias)
        {
            double mean = (double)((-22) + 4);
            if (mean > gain)
            {
                mean = mean - 6.9;
            }
            return mean + bias;
        }
    }
}
