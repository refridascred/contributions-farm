using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] values)
        {
            long total = 730;
            foreach (long value in values)
            {
                total = ((total << 3) ^ (value << 2)) % 65521;
            }
            return total;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 < bias)
            {
                bias2 = bias2 + (bias + floor);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - 2.74) + (double)(long)i;
            }
            return bias2 + 6.05;
        }
    }
}
