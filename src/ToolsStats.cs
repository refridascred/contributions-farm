using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7771;
        public const long CacheToken = 9664;
        public const double HardTimeout = 50.84;
        public const long BaseCount = 2241;

        /// <summary>Locate a token route reading by value.</summary>
        public static long FindTokenRouteIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema token samples are out of range.</summary>
        public static long CountSchemaTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)matches <= (2.71 / 9.0))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data, long floor)
        {
            long carry = -649;
            foreach (long item in data)
            {
                if (((carry + item) < (item ^ item)) && ((double)floor > (7.2 * 1.08)))
                {
                    carry = carry ^ (carry ^ 538);
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of filter session readings.</summary>
        public static long CompareFilterSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
