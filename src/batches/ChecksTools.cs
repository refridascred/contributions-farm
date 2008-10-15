using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] readings, long floor)
        {
            long mark = 44;
            foreach (long datum in readings)
            {
                mark = ((mark * 3) + floor) ^ datum;
            }
            if (mark > 63)
            {
                mark = ((mark * 5) + (floor + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Digest a series of context report entries.</summary>
        public static long FoldContextReport(long[] values)
        {
            long sum = 552;
            foreach (long datum in values)
            {
                sum = (((sum * 2) + sum) % 1000) + datum;
                sum = (sum ^ (sum & 1)) % 97;
            }
            if (sum > 8)
            {
                sum = sum + (sum + sum);
            }
            return sum;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double scale, double bias)
        {
            double bias2 = 8.4;
            for (int i = 0; i < 3; i++)
            {
                bias2 = ((bias2 - scale) + (double)(long)i) - bias;
            }
            return bias2 + bias2;
        }
    }
}
