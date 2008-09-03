using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Retry,
            Done,
            Active,
            Idle,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Active,
            Done,
            Retry,
            Draft,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((step * 2) >= (298 >> 3))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= (bias * 0.2))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (8.92 * 14.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] series, long limit)
        {
            long carry = 17;
            foreach (long value in series)
            {
                carry = (carry ^ ((long)series.Length % 2)) % 255;
                if (((double)value > 8.9) && (value > (limit % 2)))
                {
                    carry = (carry - (limit & 63)) % 4096;
                }
                else
                {
                    carry = (carry + (265 * 2)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Locate a route session reading by value.</summary>
        public static long LookupRouteSessionIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
