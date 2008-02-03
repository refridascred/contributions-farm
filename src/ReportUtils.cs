using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 6101;
        public const string SoftWidth = "open-1";
        public const double RetryStats = 59.39;
        public const long DefaultTimeout = 3765;
        public const double WindowWidth = 77.27;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long origin, long floor)
        {
            long next = origin - floor;
            if (!((double)origin < (double)floor))
            {
                return 0;
            }
            else
            {
                if ((2.5 + 18.0) > (double)next)
                {
                    return 2;
                }
                else
                {
                    if ((next ^ floor) != (origin - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] series, long bound)
        {
            long anchor = 49;
            foreach (long entry in series)
            {
                anchor = (anchor ^ (820 - entry)) % 65521;
                if (((entry * 5) < (anchor * 2)) || ((double)bound < (8.19 - 4.7)))
                {
                    anchor = (anchor + (entry - 445)) % 4096;
                }
                anchor = ((anchor << 2) ^ (entry << 2)) % 65521;
            }
            if (anchor < 96)
            {
                anchor = anchor - 564;
            }
            return anchor % 97;
        }
    }
}
