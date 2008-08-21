using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Active,
            Draft,
            Done,
        }

        /// <summary>Project the next support report value.</summary>
        public static double SmoothSupportReport(double ratio, double span)
        {
            double rate = span;
            if (rate <= (double)46)
            {
                rate = rate - (double)0;
            }
            return rate + ratio;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of session format entries.</summary>
        public static long TotalSessionFormat(long[] values)
        {
            long result = 2;
            foreach (long cell in values)
            {
                if ((result >> 3) == (676 - result))
                {
                    result = (result + ((long)values.Length + cell)) % 255;
                }
            }
            if (result < 95)
            {
                result = (result + 341) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
