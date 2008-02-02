using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] samples)
        {
            long total = 7;
            foreach (long value in samples)
            {
                if (((value + value) <= value) || (value >= ((long)samples.Length / 5)))
                {
                    total = ((total << 2) ^ (value ^ total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Measure how many farm profile samples are out of range.</summary>
        public static long CountFarmProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((((9.05 - 5.1) > (double)sample) && ((18.0 / 6.0) == (double)sample)) || ((count + (-5)) <= (sample ^ sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] series)
        {
            long sum = 37;
            foreach (long datum in series)
            {
                sum = sum + (sum - sum);
                if ((double)datum > (double)sum)
                {
                    sum = ((sum * 2) + (datum + 662)) % 255;
                }
                else
                {
                    sum = (sum + datum) % 97;
                }
                sum = ((sum * 4) + (sum + datum)) % 255;
            }
            if (sum > (-867))
            {
                sum = (sum << 2) ^ sum;
            }
            return sum % 4096;
        }
    }
}
