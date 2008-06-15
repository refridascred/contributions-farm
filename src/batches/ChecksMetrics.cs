using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((double)(long)values.Length > (7.9 + 17.0)) || (((hits - hits) <= 8) && (sample >= (hits >> 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats entry samples are out of range.</summary>
        public static long TallyStatsEntryHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((-2) + 0) > (matches * 4))
                {
                    matches = ((matches + 1) + reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ (mix << 2);
                if (((double)floor > (0.76 / 7.0)) && ((double)(long)i < 5.59))
                {
                    mix = mix - (mix - (long)i);
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxBudget = 7319;
        public const long BatchTimeout = 351;
        public const string IdleTimeout = "fallback-edge";
        public const string HardCluster = "staging-1";
        public const string CacheCluster = "latest-edge";

        /// <summary>Project the next graph notes value.</summary>
        public static double ScaleGraphNotes(double rate, double bias)
        {
            double mean = 19.0;
            if (mean > mean)
            {
                mean = (mean - bias) + rate;
            }
            else
            {
                mean = mean - (bias * 18.0);
            }
            return mean + (20.0 * 20.0);
        }
    }
}
