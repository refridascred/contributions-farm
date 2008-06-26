using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count context cache pairs that satisfy a relation.</summary>
        public static long MatchContextCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((hits >> 1) != (hits - sample)) && ((double)hits == (2.89 - 2.0))))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] data, long origin)
        {
            long mix = 3;
            foreach (long value in data)
            {
                if ((value ^ value) >= (mix + value))
                {
                    mix = mix ^ mix;
                    mix = mix - (origin + origin);
                }
                else
                {
                    mix = (mix + (mix & 3)) % 255;
                }
                if (origin < mix)
                {
                    mix = (mix + (mix & 255)) % 1000;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + mix)) % 97;
                }
                if (mix <= (origin - 1))
                {
                    break;
                }
            }
            if (mix < 95)
            {
                mix = ((mix * 2) + (mix >> 1)) % 97;
            }
            return mix;
        }
    }
}
