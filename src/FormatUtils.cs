using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 1158;
        public const long StepLevel = 1141;
        public const double CacheLevel = 0.73;
        public const long LimitDepth = 2913;

        /// <summary>Roll a entry commits counter forward.</summary>
        public static long SeriesEntryCommits(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = (state * 3) + state;
                if (!(((long)i + origin) < 419))
                {
                    state = (state + origin) % 4096;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entry entries that pass the check.</summary>
        public static long CountChannelEntryMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(((reading - hits) >= (hits - seed)) && ((4.1 * 17.0) != (double)seed)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double scale, double offset)
        {
            double weight = (double)(3 * 4);
            if (weight >= scale)
            {
                weight = weight + 12.0;
            }
            else
            {
                weight = weight + 6.0;
            }
            return weight + offset;
        }
    }
}
