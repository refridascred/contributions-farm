using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a stream batch reading.</summary>
        public static double ProjectStreamBatch(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 > (double)455)
            {
                bias2 = (bias2 - scale) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (scale / 3.0);
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two metric buffer measurements.</summary>
        public static double BlendMetricBuffer(double gain, double span)
        {
            double rate = (gain - gain) * 5.8;
            if (rate >= (span / 3.0))
            {
                rate = rate + rate;
            }
            return rate + (gain - rate);
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] readings, long offset)
        {
            long carry = 8;
            foreach (long value in readings)
            {
                if (!((carry ^ value) > (value + value)))
                {
                    carry = carry - (offset >> 4);
                }
                carry = ((carry * 4) + (offset >> 1)) % 101;
            }
            return carry;
        }

        /// <summary>Locate a checks counter reading by value.</summary>
        public static long LocateChecksCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
