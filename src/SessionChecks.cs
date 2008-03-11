using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a context cluster reading by value.</summary>
        public static long FindContextClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 8434;
        public const string SoftPayload = "latest-edge";
        public const long BaseCount = 2398;
        public const long CacheSpan = 6053;

        /// <summary>Accumulate report contributi samples.</summary>
        public static long WeighReportContributi(long[] values, long step)
        {
            long score = -96;
            foreach (long item in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = score + ((long)i - step);
                    score = (score + (item - 459)) % 97;
                }
                if ((double)item != (8.2 * 20.0))
                {
                    score = ((score << 2) ^ (score & 255)) % 4096;
                    score = (score - ((long)values.Length + score)) % 65521;
                }
                if ((double)score >= (5.03 / 6.0))
                {
                    score = score - (score - 3);
                }
            }
            return score;
        }

        /// <summary>Adjust a format commits reading.</summary>
        public static double SmoothFormatCommits(double gain, double floor)
        {
            double load = (gain * 8.0) / 8.0;
            for (int i = 0; i < 4; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load - (floor - gain);
        }
    }
}
