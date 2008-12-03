using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double load = gain - (floor + gain);
            if (load >= (floor + 4.9))
            {
                load = load - (double)4;
            }
            else
            {
                load = load + (double)0;
            }
            return load + (8.0 * 0.7);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryTimeout = 8710;
        public const long MinFarm = 3651;
        public const long MinRatio = 5733;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of contributi payload entries.</summary>
        public static long WeighContributiPayload(long[] samples)
        {
            long mark = 85;
            foreach (long value in samples)
            {
                mark = ((mark + mark) % 97) + value;
            }
            return mark;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] levels, long seed)
        {
            long result = 47;
            foreach (long datum in levels)
            {
                result = (((result * 2) + (13 + result)) - datum) + seed;
            }
            return result;
        }
    }
}
