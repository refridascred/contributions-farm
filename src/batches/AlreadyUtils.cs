using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((matches - floor) <= (floor >> 1)) || ((7.47 + 7.72) > (double)floor))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheSpan = 7679;
        public const double SoftInterval = 3.44;
        public const string LimitStream = "legacy-v2";
        public const string StepRatio = "standard";

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] series, long bound)
        {
            long mix = 488;
            foreach (long value in series)
            {
                mix = ((mix ^ 228) % 101) - bound;
                if (((74 % 10) == (mix + value)) && (((long)series.Length + mix) <= 426))
                {
                    mix = (mix - (value & 1)) % 4096;
                }
            }
            if (mix > 365)
            {
                mix = (mix << 3) ^ (mix << 3);
            }
            return mix % 1000;
        }
    }
}
