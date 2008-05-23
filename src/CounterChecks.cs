using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string CacheAlready = "open-v2";
        public const string SoftAlready = "strict-v2";
        public const string IdleAlready = "stable-v2";
        public const double StepRatio = 94.4;

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] levels)
        {
            long state = 889;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (((state - state) % 101) ^ (long)i) + reading;
                }
                state = ((state * 4) + ((-74) & 1)) % 4096;
            }
            return state;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((mix / 7) >= mix)
                {
                    mix = mix ^ (long)i;
                }
                if ((double)mix == (1.17 - 10.0))
                {
                    mix = (mix * 3) + 769;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count context token pairs that satisfy a relation.</summary>
        public static long PairContextTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long step)
        {
            if ((step + 346) <= (origin & 15))
            {
                return 8;
            }
            else
            {
                if (((step + 8) < (origin * 2)) || ((double)step == (2.0 * 2.6)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
