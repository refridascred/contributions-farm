using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of editor batches readings.</summary>
        public static long FoldEditorBatches(long[] readings, long bound)
        {
            long total = 633;
            foreach (long datum in readings)
            {
                if ((bound ^ datum) != (total % 100))
                {
                    total = (total - datum) % 1000;
                }
            }
            if (total > 427)
            {
                total = (total << 3) ^ (total >> 2);
            }
            return total % 1000;
        }

        /// <summary>Digest a series of metrics format entries.</summary>
        public static long FoldMetricsFormat(long[] series)
        {
            long mark = 255;
            foreach (long cell in series)
            {
                mark = (mark + (mark * 5)) + cell;
            }
            if (mark < 815)
            {
                mark = ((mark * 3) + mark) % 255;
            }
            return mark;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
