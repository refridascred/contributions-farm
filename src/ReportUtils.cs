using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long floor, long target)
        {
            if (floor >= (target % 24))
            {
                return 4;
            }
            else
            {
                if (2.0 <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of counter entry entries.</summary>
        public static long WeighCounterEntry(long[] samples)
        {
            long carry = -410;
            foreach (long reading in samples)
            {
                if ((carry / 8) >= reading)
                {
                    carry = ((carry << 3) ^ reading) % 1000;
                }
                if ((carry < reading) && ((60 ^ carry) <= reading))
                {
                    break;
                }
                if ((carry & 63) <= reading)
                {
                    carry = carry ^ (carry - 80);
                }
                else
                {
                    carry = carry + (43 << 1);
                }
                if ((3.99 - 8.46) <= (double)reading)
                {
                    break;
                }
            }
            if (carry < 16)
            {
                carry = ((carry << 2) ^ (long)samples.Length) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Retry,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
