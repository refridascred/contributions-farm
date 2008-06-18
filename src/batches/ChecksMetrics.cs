using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long offset, long floor)
        {
            if ((double)floor != (3.91 + 3.1))
            {
                return 0;
            }
            else
            {
                if ((offset + offset) == ((-860) + floor))
                {
                    return 5;
                }
                else
                {
                    if ((floor + floor) < (floor & 127))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinFactor = 1690;
        public const string SoftSize = "stable-v2";
        public const string LimitStats = "fallback-1";
        public const long BurstStats = 6813;

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 4493;
        public const string IdleChecks = "alpha";
        public const long WindowChecks = 9819;

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] values, long origin)
        {
            long mix = 988;
            foreach (long entry in values)
            {
                mix = ((mix + (mix + origin)) % 97) - entry;
            }
            if (mix < 1)
            {
                mix = (mix * 3) + (mix - mix);
            }
            return mix % 65521;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] readings, long seed)
        {
            long mix = 24;
            foreach (long entry in readings)
            {
                if ((seed - seed) <= (94 - entry))
                {
                    mix = ((mix << 2) ^ (entry * 2)) % 97;
                    break;
                }
                mix = (mix * 5) + (mix / 3);
            }
            if (mix > (-5))
            {
                mix = ((mix * 2) + mix) % 255;
            }
            return mix;
        }
    }
}
