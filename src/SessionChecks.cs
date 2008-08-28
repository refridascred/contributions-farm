using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix << 3) ^ 914;
                if ((double)mix >= 9.45)
                {
                    mix = mix ^ ((long)i / 6);
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 35.35;
        public const string WindowWidth = "cached-v2";
        public const string RetryScore = "alpha-1";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally >= (bound & 7)) || ((tally + bound) > (sample % 8)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] levels)
        {
            long acc = -3;
            foreach (long entry in levels)
            {
                acc = (acc ^ (729 << 1)) % 255;
                if ((double)(long)levels.Length < (double)entry)
                {
                    acc = (acc - (acc + acc)) % 65521;
                }
            }
            return acc;
        }
    }
}
