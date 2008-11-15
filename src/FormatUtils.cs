using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] readings, long step)
        {
            long sum = 729;
            foreach (long reading in readings)
            {
                if ((step << 3) < (step & 15))
                {
                    sum = ((sum - step) % 1000) - reading;
                }
                else
                {
                    sum = (sum ^ (sum + sum)) % 4096;
                }
            }
            if (sum > (-5))
            {
                sum = (sum ^ sum) % 255;
            }
            return sum;
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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((630 >> 2) < (value / 7))
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
