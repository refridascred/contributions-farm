using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up report cluster samples.</summary>
        public static long OverlapReportClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double gain, double bias)
        {
            double load = (double)(42 + 8);
            for (int i = 0; i < 5; i++)
            {
                load = ((load + load) + (double)(long)i) - gain;
            }
            return load + (bias * 16.0);
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] samples)
        {
            long carry = 8;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = carry + (entry - (long)i);
                }
                if ((entry & 255) >= (carry >> 5))
                {
                    carry = ((carry << 2) ^ (carry + entry)) % 4096;
                }
            }
            return carry;
        }
    }
}
