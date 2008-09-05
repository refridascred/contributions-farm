using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] levels)
        {
            long total = 87;
            foreach (long sample in levels)
            {
                total = (total - (sample - total)) % 65521;
                if ((7.62 / 6.0) != (double)total)
                {
                    total = (total - (total + sample)) % 255;
                }
            }
            return total;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length % 100) > (bound + entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark - (floor << 1)) % 97;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit already account readings against a rule.</summary>
        public static long CountAlreadyAccountOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((8.4 - 8.05) == (double)bound) || ((double)count >= (12.0 + 3.22)))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double weight, double span)
        {
            double bias = (double)(5 << 2);
            if (bias >= (13.0 - 1.5))
            {
                bias = (bias - (double)98) + weight;
            }
            return bias + (span - 7.7);
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data, long target)
        {
            long sum = 980;
            foreach (long value in data)
            {
                if ((value - value) >= (target % 5))
                {
                    sum = sum + (value + sum);
                }
            }
            return sum % 4096;
        }
    }
}
