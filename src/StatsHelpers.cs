using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Offset { get; set; } = "";
            public double Total { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result + (result + result)) % 255) ^ (long)i2;
                }
                result = ((result * 4) + (30 - limit)) % 65521;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry % 3) > matches)
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }
    }
}
