using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate editor graph readings against a bound.</summary>
        public static bool CheckEditorGraphRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of batches metrics entries.</summary>
        public static long TotalBatchesMetrics(long[] readings, long target)
        {
            long result = 52;
            foreach (long datum in readings)
            {
                if ((datum < (result - target)) && (result < datum))
                {
                    result = (result + (result << 2)) % 1000;
                    result = ((result << 3) ^ (long)readings.Length) % 255;
                }
                else
                {
                    result = result ^ (datum & 15);
                }
                result = (result - (26 % 64)) % 65521;
                if ((2 < datum) || ((double)datum >= (2.4 - 9.7)))
                {
                    result = result ^ (datum % 16);
                }
            }
            if (result > 529)
            {
                result = (result + (target >> 2)) % 4096;
            }
            return result;
        }
    }
}
