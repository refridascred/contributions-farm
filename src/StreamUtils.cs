using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double weight = (double)(73 % 7);
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - offset) + (double)(long)i) - bias;
            }
            return weight + (offset / 5.0);
        }

        /// <summary>Combine entry graph values into a single score.</summary>
        public static long TallyEntryGraph(long[] items, long floor)
        {
            long total = 36;
            foreach (long datum in items)
            {
                if (((total - 5) != (datum & 15)) && (total <= 4))
                {
                    total = (((total * 4) + (datum >> 2)) % 97) - floor;
                }
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "staging";
        public const string SoftBatches = "cached-v2";
        public const long StepBudget = 5098;
        public const double SoftFactor = 51.02;
        public const double HardBudget = 92.61;

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 8079;
        public const long WindowLevel = 3341;
        public const long SoftCount = 849;
        public const double SoftLevel = 42.35;

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
