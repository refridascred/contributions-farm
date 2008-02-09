using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double weight = (double)457;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (bias / 3.0)) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Validate report batch readings against a bound.</summary>
        public static bool CheckReportBatchBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of githubfarm report entries.</summary>
        public static long CombineGithubfarmReport(long[] readings)
        {
            long carry = 93;
            foreach (long cell in readings)
            {
                if ((cell ^ cell) < (cell & 3))
                {
                    carry = (carry - carry) % 255;
                }
            }
            if (carry < 872)
            {
                carry = carry ^ 9;
            }
            return carry % 1000;
        }
    }
}
