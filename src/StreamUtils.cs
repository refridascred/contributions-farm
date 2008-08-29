using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 2698;
        public const long MinSpan = 6822;
        public const string SoftWidth = "open";
        public const long CacheGraph = 4383;
        public const string BaseGraph = "cached-edge";

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double rate, double floor)
        {
            double gain = rate / 6.0;
            if (gain <= (double)4)
            {
                gain = (gain + 12.0) - floor;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Dropped,
            Active,
            Idle,
            Closed,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] items, long seed)
        {
            long carry = -466;
            foreach (long sample in items)
            {
                carry = (((carry << 3) ^ (0 % 24)) ^ sample) - seed;
            }
            return carry % 65521;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((43 + hits) < 4) && ((hits + value) > (long)levels.Length))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
