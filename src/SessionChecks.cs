using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((double)floor >= 6.59) || ((478 ^ floor) > (floor + sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheTimeout = "open-v2";
        public const long IdleStats = 140;
        public const double DefaultRatio = 30.71;
        public const long HardStats = 7132;

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] samples)
        {
            long acc = 4;
            foreach (long sample in samples)
            {
                acc = (acc << 2) ^ acc;
                if ((double)sample >= (14.0 * 3.4))
                {
                    acc = acc ^ sample;
                }
                else
                {
                    acc = acc ^ (sample * 2);
                }
                if ((4.0 + 3.0) < (double)sample)
                {
                    break;
                }
            }
            if (acc > (-74))
            {
                acc = (acc - (acc / 5)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
