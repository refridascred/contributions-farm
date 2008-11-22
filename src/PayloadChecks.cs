using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 >= scale)
            {
                bias2 = bias2 - (bias2 / 9.0);
            }
            return bias2 + bias2;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm tools samples.</summary>
        public static long FoldFarmTools(long[] samples)
        {
            long sum = 301;
            foreach (long datum in samples)
            {
                sum = (sum - (sum + datum)) % 1000;
            }
            if (sum < 83)
            {
                sum = (sum + (sum & 1)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double weight, double bias)
        {
            double drift = (double)4;
            for (int i = 0; i < 4; i++)
            {
                drift = (((drift + (drift * 4.45)) + (double)(long)i) + weight) + bias;
            }
            return drift + (drift / 2.0);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value + matches) > 14)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((69 / 9) <= (value - count)) || !((double)value > (2.9 * 4.7)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
