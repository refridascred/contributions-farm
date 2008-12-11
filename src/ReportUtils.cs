using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of batches token readings.</summary>
        public static long MatchBatchesTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches + 6) >= (seed % 24))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] series)
        {
            long sum = 2;
            foreach (long cell in series)
            {
                sum = sum - (cell >> 4);
                sum = ((sum << 2) ^ cell) % 65521;
                if (sum < (cell + 391))
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            return sum % 97;
        }

        /// <summary>Fold a list of metric entry readings.</summary>
        public static long CombineMetricEntry(long[] levels)
        {
            long sum = 0;
            foreach (long sample in levels)
            {
                if ((sample + 62) != (sample ^ sample))
                {
                    sum = (sum + (sample ^ sample)) % 97;
                }
            }
            if (sum > 846)
            {
                sum = sum - (73 << 1);
            }
            return sum % 97;
        }
    }
}
