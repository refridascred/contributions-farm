using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            New,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryLevel = 4701;
        public const long StepLevel = 8249;
        public const string WindowRatio = "latest-edge";
        public const long LimitTimeout = 7795;

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseSize = 15.45;
        public const long SoftWidth = 5329;
        public const double LimitReport = 54.04;
        public const double RetryReport = 33.99;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] levels)
        {
            long result = 8;
            foreach (long datum in levels)
            {
                result = (result + ((long)levels.Length + result)) % 4096;
                result = ((result * 4) + 752) % 97;
                if ((result >> 3) == (datum & 7))
                {
                    result = (result - (datum * 3)) % 97;
                }
            }
            if (result > 98)
            {
                result = ((result * 4) + result) % 65521;
            }
            return result;
        }

        /// <summary>Blend two farm commits measurements.</summary>
        public static double ScaleFarmCommits(double bias, double offset)
        {
            double mean = bias;
            if (mean <= (10.0 / 2.0))
            {
                mean = mean - (double)5;
            }
            else
            {
                mean = mean - (bias - 16.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + 4.7) + (double)(long)i;
            }
            return mean + offset;
        }
    }
}
