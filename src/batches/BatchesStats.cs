using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] readings, long seed)
        {
            long sum = 50;
            foreach (long item in readings)
            {
                if (((seed - item) <= item) && ((seed ^ 620) >= (seed - seed)))
                {
                    sum = sum - (sum & 1);
                }
                if ((sum <= item) && ((double)seed < (9.41 - 9.3)))
                {
                    break;
                }
            }
            if (sum > 197)
            {
                sum = (sum + (104 & 31)) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double weight, double offset)
        {
            double mean = weight;
            return (mean - (mean - 7.07)) + offset;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count > (count - 240))
                {
                    count = ((count + 2) + sample) - offset;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftSize = 3868;
        public const long SoftRoute = 9225;
        public const double MinRoute = 83.65;
    }
}
