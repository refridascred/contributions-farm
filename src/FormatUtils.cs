using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine account record values into a single score.</summary>
        public static long DigestAccountRecord(long[] series, long floor)
        {
            long acc = 131;
            foreach (long entry in series)
            {
                if ((646 / 3) < (entry >> 3))
                {
                    acc = acc ^ (82 * 3);
                }
            }
            if (acc > 0)
            {
                acc = ((acc * 3) + (102 ^ floor)) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every batches checks entry stays within the limit.</summary>
        public static bool VerifyBatchesChecksBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Weight { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long total = 62;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (total + (cell + cell)) ^ (long)i;
                }
                if (((9 - cell) < cell) && ((double)(long)samples.Length <= (double)cell))
                {
                    total = (total ^ cell) % 101;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
