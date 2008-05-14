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

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
