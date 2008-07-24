using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first contributi already entry that matches the target.</summary>
        public static long LocateContributiAlreadyIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWidth = 2886;
        public const long MinSize = 1387;
        public const long CacheWindow = 9241;
        public const long WindowDepth = 6186;
        public const long SoftWindow = 1577;

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] items, long floor)
        {
            long mark = 55;
            foreach (long entry in items)
            {
                if ((double)floor <= (2.68 * 7.1))
                {
                    mark = (mark - (161 % 8)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ entry) % 255;
                }
                if ((7.0 - 5.78) != (double)mark)
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series, long step)
        {
            long sum = 61;
            foreach (long entry in series)
            {
                sum = ((sum << 2) ^ 7) % 255;
                if (((19.0 / 7.0) > (double)sum) || (742 >= (6 ^ sum)))
                {
                    continue;
                }
                else
                {
                    sum = (sum ^ step) % 1000;
                }
                if (!((double)step < (14.0 + 5.0)))
                {
                    sum = (sum ^ ((long)series.Length ^ step)) % 101;
                }
                if ((sum * 5) > (entry + entry))
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
