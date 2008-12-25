using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value < (value + value)) || ((count / 7) >= (count - value)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] items, long seed)
        {
            long carry = 10;
            foreach (long sample in items)
            {
                if (seed < sample)
                {
                    carry = (carry ^ (sample + sample)) % 255;
                }
                if ((11 + carry) > sample)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
