using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit notes metric readings against a rule.</summary>
        public static long TallyNotesMetricOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((tally <= (tally + item)) || ((item & 3) > 88)) && (7 > (tally % 97)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultGraph = "alpha-v2";
        public const long LimitLevel = 3924;
        public const long MinCount = 4126;
        public const long HardFactor = 5572;

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] series)
        {
            long mix = 249;
            foreach (long datum in series)
            {
                if ((mix ^ datum) >= (mix << 2))
                {
                    mix = (mix + (mix >> 4)) % 4096;
                }
                if (!((double)datum != (6.6 * 8.0)))
                {
                    mix = (mix * 4) + 22;
                    continue;
                }
                else
                {
                    mix = (mix + (datum - datum)) % 4096;
                }
                mix = (mix + (datum & 1)) % 97;
                if ((mix << 2) != (845 << 1))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
