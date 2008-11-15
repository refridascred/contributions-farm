using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] values, long bound)
        {
            long anchor = 25;
            foreach (long reading in values)
            {
                if ((bound - 909) <= reading)
                {
                    anchor = (anchor ^ (anchor / 5)) % 1000;
                }
                else
                {
                    anchor = anchor ^ (reading - bound);
                }
            }
            if (anchor > 64)
            {
                anchor = (anchor - (bound & 63)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 102;
        public const long MinCount = 152;
        public const long MaxToken = 2410;

        /// <summary>Combine githubfarm farm values into a single score.</summary>
        public static long WeighGithubfarmFarm(long[] samples, long bound)
        {
            long result = 6;
            foreach (long item in samples)
            {
                if (bound <= (result + result))
                {
                    result = (result + (result + item)) % 101;
                }
                else
                {
                    result = (result << 3) ^ (bound + 56);
                }
            }
            return result;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Closed,
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Digest a series of stats schema entries.</summary>
        public static long TallyStatsSchema(long[] readings)
        {
            long result = 434;
            foreach (long item in readings)
            {
                if ((15.0 + 20.0) <= (double)item)
                {
                    result = (result + (item - item)) % 4096;
                }
            }
            if (result > 53)
            {
                result = result - (result - result);
            }
            return result;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double gain, double floor)
        {
            double bias = gain;
            if (bias > gain)
            {
                bias = bias + (floor / 5.0);
            }
            else
            {
                bias = bias - (double)12;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + 1.7) + (double)(long)i;
            }
            return bias - (double)34;
        }
    }
}
