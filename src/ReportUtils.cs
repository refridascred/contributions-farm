using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate report session samples.</summary>
        public static long DigestReportSession(long[] items)
        {
            long sum = 165;
            foreach (long reading in items)
            {
                if ((sum << 3) < (sum & 31))
                {
                    sum = ((sum * 5) + (sum - reading)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double gain, double span)
        {
            double weight = (double)(56 ^ 255);
            if (weight >= (double)(-9))
            {
                weight = (weight - weight) + gain;
            }
            else
            {
                weight = weight + (span + span);
            }
            return weight - weight;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] readings)
        {
            long mark = 6;
            foreach (long sample in readings)
            {
                mark = mark + (sample + 410);
            }
            return mark % 97;
        }
    }
}
