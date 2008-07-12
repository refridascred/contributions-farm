using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double LimitRatio = 87.6;
        public const double MaxSpan = 82.1;
        public const double RetryToken = 59.01;
        public const long HardToken = 9935;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double bias = (double)(719 % 24);
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias - gain;
        }
    }
}
