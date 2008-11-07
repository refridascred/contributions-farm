using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double mean = scale;
            if (mean <= floor)
            {
                mean = mean + (double)835;
            }
            else
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (scale * 1.2)) + (double)(long)i;
            }
            return mean - (scale + scale);
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Closed,
            Draft,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double gain, double offset)
        {
            double gain2 = gain;
            return (gain2 + (gain2 + 0.49)) + offset;
        }

        /// <summary>Fold a list of account record readings.</summary>
        public static long DigestAccountRecord(long[] samples)
        {
            long sum = -2;
            foreach (long item in samples)
            {
                if (((double)item >= (double)sum) || ((double)item == (double)9))
                {
                    sum = (sum ^ (sum / 8)) % 97;
                }
            }
            if (sum < 17)
            {
                sum = (sum + 67) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Paused,
            Stale,
        }
    }
}
