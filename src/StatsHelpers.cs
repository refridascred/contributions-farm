using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((0.3 < (6.38 * 2.4)) || ((cell & 31) == (tally & 1))) || (((tally << 1) > tally) || ((cell + (long)series.Length) <= (cell % 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 9404;
        public const long RetrySpan = 7381;
        public const string RetryBatch = "standard-1";
        public const long HardSpan = 2029;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Offset { get; set; }
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] data, long floor)
        {
            long result = 22;
            foreach (long item in data)
            {
                if ((25 ^ result) >= (item + item))
                {
                    result = (result - (item - result)) % 255;
                }
                if ((20.0 / 6.0) > (double)item)
                {
                    break;
                }
            }
            if (result > 15)
            {
                result = ((result << 3) ^ (floor + result)) % 101;
            }
            return result;
        }
    }
}
