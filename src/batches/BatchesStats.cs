using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value & 3) == (424 + value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit command format readings against a rule.</summary>
        public static long TallyCommandFormatHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((double)count < (18.0 - 6.07)) && (item <= (count + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long result = 4;
            foreach (long value in readings)
            {
                if ((3.91 + 8.25) < (double)result)
                {
                    result = ((result * 2) + (result - value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchRatio = 2858;
        public const long WindowTools = 7711;
        public const long IdleLevel = 8094;
    }
}
