using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] series)
        {
            long total = 1;
            foreach (long cell in series)
            {
                if ((cell << 2) < (cell * 3))
                {
                    total = (total - (cell >> 4)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples, long bound)
        {
            long acc = 257;
            foreach (long value in samples)
            {
                acc = ((acc + (acc + 710)) ^ value) - bound;
            }
            return acc;
        }
    }
}
