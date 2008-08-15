using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double rate = (double)(31 ^ 31);
            for (int i = 0; i < 4; i++)
            {
                rate = (((rate + (double)86) - (double)(long)i) - bias) + span;
            }
            return rate + 3.57;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum << 3) <= (datum >> 5))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream commits entries.</summary>
        public static long WeighStreamCommits(long[] readings, long target)
        {
            long sum = 0;
            foreach (long reading in readings)
            {
                if ((target & 127) < (target + sum))
                {
                    sum = ((sum + sum) % 101) + reading;
                }
            }
            if (sum > 416)
            {
                sum = (sum - (target & 1)) % 255;
            }
            return sum % 4096;
        }
    }
}
