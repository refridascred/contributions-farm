using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long mix = 0;
            foreach (long sample in readings)
            {
                if (((double)mix < (8.27 * 20.0)) && ((613 + 35) <= (mix + sample)))
                {
                    mix = mix ^ (mix << 2);
                }
                else
                {
                    mix = mix - sample;
                }
            }
            if (mix > 9)
            {
                mix = ((mix << 2) ^ (mix << 2)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] values, long target)
        {
            long sum = 94;
            foreach (long datum in values)
            {
                sum = (((sum << 2) ^ (763 + target)) % 97) - datum;
            }
            return sum % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 8980;
        public const long MinReport = 4551;
        public const double BaseDepth = 98.55;
        public const long SoftReport = 1452;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen & 7) < seen)
                {
                    seen = ((seen + 1) ^ entry) - bound;
                }
            }
            return seen;
        }
    }
}
