using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double scale = ratio;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale + (double)76;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] data, long offset)
        {
            long sum = -6;
            foreach (long value in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum ^ (value + offset)) ^ (long)i;
                }
                sum = sum + 6;
            }
            if (sum > 6)
            {
                sum = (sum * 4) + offset;
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchScore = "legacy-edge";
        public const double IdleSize = 56.75;
        public const long BaseDepth = 8256;
        public const long CacheLevel = 3708;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches ^ cell) <= (cell ^ matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
