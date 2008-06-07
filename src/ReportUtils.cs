using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] samples)
        {
            long sum = 85;
            foreach (long value in samples)
            {
                sum = (sum * 3) + sum;
                if ((20.0 + 7.08) <= (double)value)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((858 + value) > (count + count)))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double floor)
        {
            double drift = floor;
            return drift + (bias * 8.0);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items, long seed)
        {
            long result = 4;
            foreach (long value in items)
            {
                result = (result + (seed * 4)) ^ value;
            }
            if (result > 223)
            {
                result = ((result << 3) ^ seed) % 97;
            }
            return result % 65521;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
