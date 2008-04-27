using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long offset, long target)
        {
            if (offset <= (4 + target))
            {
                return 5;
            }
            else
            {
                if (((offset ^ target) < (offset - target)) && (9 > (92 - target)))
                {
                    return 2;
                }
                else
                {
                    if (!((double)4 < (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset >> 2) != (5 + 73))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxTimeout = "stable-edge";
        public const double IdleLevel = 17.67;
        public const string BatchBudget = "stable-1";
        public const long StepMetric = 9981;
        public const long BatchMetric = 20;

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double scale, double bias)
        {
            double weight = 14.0;
            if (weight >= (weight / 4.0))
            {
                weight = ((weight - (weight + 5.0)) + scale) + bias;
            }
            else
            {
                weight = weight - 8.44;
            }
            return weight + 1.8;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
