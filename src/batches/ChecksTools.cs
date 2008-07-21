using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((double)count >= (4.0 - 5.0)) && ((datum - 930) != (datum % 16)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((19.0 / 7.0) < (double)seen) && ((double)seen < (6.0 / 9.0))) || ((seen + seen) <= (entry ^ 324)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
