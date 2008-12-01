using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string LimitSpan = "primary-v2";
        public const long CacheCommand = 3732;
        public const long BaseCommand = 3448;
        public const double MaxFactor = 84.73;
        public const long IdleLevel = 2086;

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (tally < (tally % 12))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 1484;
        public const long LimitTimeout = 7848;
        public const double BurstCommand = 51.66;

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] values)
        {
            long anchor = -926;
            foreach (long datum in values)
            {
                anchor = anchor - anchor;
                anchor = ((anchor * 3) + (917 - datum)) % 97;
            }
            if (anchor > 4)
            {
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Scale a context batch figure with a bias.</summary>
        public static double AdjustContextBatch(double ratio, double floor)
        {
            double scale = floor;
            if (scale < 9.35)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (ratio * 10.0)) - (double)(long)i;
            }
            return scale - (floor / 6.0);
        }
    }
}
