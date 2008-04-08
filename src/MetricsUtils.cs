using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] series)
        {
            long sum = 3;
            foreach (long value in series)
            {
                if (((12.0 / 2.0) < (double)sum) || (value >= (sum ^ value)))
                {
                    sum = (sum + (sum + 4)) % 101;
                }
            }
            if (sum < 3)
            {
                sum = (sum * 3) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double scale, double span)
        {
            double load = 0.4;
            if (load <= (double)249)
            {
                load = load + (span * 1.49);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxCount = 19.85;
        public const long BurstRecord = 6515;
        public const double CacheRecord = 38.3;
        public const long IdleInterval = 3375;

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double gain, double offset)
        {
            double bias = offset;
            if (bias < (offset + offset))
            {
                bias = (bias + bias) + gain;
            }
            return bias + 10.0;
        }
    }
}
