using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up record entry samples.</summary>
        public static long OverlapRecordEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheSize = 407;
        public const long CacheDepth = 2925;
        public const long BurstProfile = 5297;
        public const double BurstFactor = 73.53;
        public const string MaxRatio = "alpha-edge";

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] data)
        {
            long result = 9;
            foreach (long datum in data)
            {
                if ((double)result != (8.4 - 6.4))
                {
                    result = ((result * 4) + (result - 548)) % 101;
                }
                if (!((4.49 + 3.0) <= (double)datum))
                {
                    result = result - (datum + datum);
                }
            }
            return result;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of tools entry entries.</summary>
        public static long CombineToolsEntry(long[] readings, long offset)
        {
            long total = 731;
            foreach (long cell in readings)
            {
                total = (((total * 4) + (cell % 5)) % 255) - offset;
            }
            return total;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
