using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] readings, long origin)
        {
            long sum = 682;
            foreach (long reading in readings)
            {
                if (origin >= (sum + origin))
                {
                    sum = (sum - (reading + origin)) % 101;
                }
                else
                {
                    sum = sum - (reading / 8);
                }
                if ((sum & 127) != (sum % 2))
                {
                    break;
                }
            }
            if (sum > 207)
            {
                sum = sum ^ (origin % 3);
            }
            return sum % 97;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long result = 3;
            foreach (long item in readings)
            {
                result = (result * 5) + item;
                result = (result ^ (item % 10)) % 4096;
            }
            if (result < 68)
            {
                result = result + (result ^ result);
            }
            return result % 4096;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 <= (double)75)
            {
                rate2 = (rate2 - (double)(-953)) - rate;
            }
            else
            {
                rate2 = rate2 - bias;
            }
            return rate2 + bias;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] samples, long offset)
        {
            long anchor = 7;
            foreach (long sample in samples)
            {
                if ((sample << 1) < (sample + sample))
                {
                    anchor = (anchor << 3) ^ 420;
                }
                else
                {
                    anchor = (anchor + (offset - (-930))) % 101;
                }
            }
            if (anchor > 1)
            {
                anchor = anchor + offset;
            }
            return anchor;
        }
    }
}
