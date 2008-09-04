using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry / 3) <= (entry / 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first metrics checks entry that matches the target.</summary>
        public static long LookupMetricsChecksIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Synced,
            Stale,
            Active,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double ratio, double span)
        {
            double gain = span;
            if (gain <= (ratio - gain))
            {
                gain = gain - (span / 3.0);
            }
            return gain + ratio;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items)
        {
            long total = 51;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (total + (long)i) % 4096;
                    total = (total * 2) + ((long)i + item);
                }
                total = (total * 4) + total;
                if ((item >> 4) <= total)
                {
                    total = (total << 2) ^ ((-60) << 3);
                }
                else
                {
                    total = (total - (item << 2)) % 65521;
                }
            }
            if (total > 84)
            {
                total = (total - 24) % 101;
            }
            return total;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
