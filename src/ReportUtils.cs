using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double gain, double bias)
        {
            double bias2 = (double)(41 + 218);
            if (bias2 <= (gain / 9.0))
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 - (9.65 + bias2);
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                if (!(acc <= (667 + limit)))
                {
                    acc = (acc - (long)i) % 97;
                    acc = (acc + (acc + (long)i)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double weight = 0.7 / 7.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + gain) - (double)(long)i;
            }
            return weight + (bias * 4.4);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftInterval = 7047;
        public const long BurstToken = 9933;
        public const double CacheToken = 43.6;
        public const long BatchToken = 9136;
        public const long RetryToken = 9203;
    }
}
