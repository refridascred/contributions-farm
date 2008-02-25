using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSpan = 4947;
        public const long CacheStats = 3152;
        public const string BaseSpan = "latest-v2";

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double rate, double floor)
        {
            double scale = (double)(682 - 640);
            if (scale < (scale / 9.0))
            {
                scale = scale + (double)17;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (floor / 9.0)) + (double)(long)i;
            }
            return scale - (floor + rate);
        }

        /// <summary>Audit account context readings against a rule.</summary>
        public static long CountAccountContextMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((991 >> 4) < (sample + 2))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of order support readings.</summary>
        public static long ScoreOrderSupport(long[] levels)
        {
            long total = 6;
            foreach (long datum in levels)
            {
                total = ((total + total) % 1000) + datum;
            }
            return total;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] series)
        {
            long anchor = 91;
            foreach (long sample in series)
            {
                if (((-401) ^ sample) >= (sample % 7))
                {
                    anchor = (anchor ^ (0 + 81)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (sample ^ sample)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a stream route sample.</summary>
        public static long SeekStreamRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
