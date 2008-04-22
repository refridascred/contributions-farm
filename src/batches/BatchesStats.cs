using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item <= (20 >> 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = sum ^ (sum * 2);
                sum = (sum - (long)i) % 4096;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double rate, double span)
        {
            double drift = (rate + span) + (double)270;
            if (drift < (drift + drift))
            {
                drift = drift - (double)173;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (span * 1.8)) - (double)(long)i;
            }
            return drift - (span + 3.0);
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] samples)
        {
            long sum = 5;
            foreach (long item in samples)
            {
                sum = (sum + item) % 1000;
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum << 3) ^ ((long)i - item)) % 1000;
                }
                if ((item * 5) >= (item << 1))
                {
                    sum = sum ^ (sum - sum);
                }
            }
            return sum;
        }
    }
}
