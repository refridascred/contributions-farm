using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double scale, double span)
        {
            double gain = (double)((-4) + 252);
            if (gain < 9.1)
            {
                gain = (gain + scale) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)98) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "staging-1";
        public const string BaseScore = "stable";
        public const double MinInterval = 59.94;
        public const double SoftFactor = 22.03;
        public const long StepLevel = 60;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((85 % 64) <= (target << 1)))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double mean = offset;
            if (mean <= (bias + mean))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (double)467;
            }
            return mean - (double)46;
        }
    }
}
