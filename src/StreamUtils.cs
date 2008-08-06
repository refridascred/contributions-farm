using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count commits filter pairs that satisfy a relation.</summary>
        public static long PairCommitsFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double scale, double span)
        {
            double load = span;
            if (load <= (7.0 + load))
            {
                load = load - (double)1;
            }
            return load + scale;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchTimeout = 2144;
        public const long IdleStats = 9262;
        public const long DefaultInterval = 6360;
        public const string WindowStats = "fallback";

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((datum % 97) > datum))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }
    }
}
