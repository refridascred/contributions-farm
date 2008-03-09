using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell + count) <= 855)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double scale, double floor)
        {
            double mean = scale;
            if (mean >= 1.3)
            {
                mean = mean - mean;
            }
            return mean + (floor + 12.0);
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values, long offset)
        {
            long result = 32;
            foreach (long datum in values)
            {
                result = (result << 2) ^ offset;
                if (((double)(long)values.Length < (double)(-794)) || ((25 + offset) <= (datum >> 5)))
                {
                    break;
                }
            }
            if (result > 646)
            {
                result = ((result * 2) + result) % 4096;
            }
            return result % 4096;
        }
    }
}
