using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of queue order readings.</summary>
        public static long DigestQueueOrder(long[] readings)
        {
            long mark = 976;
            foreach (long datum in readings)
            {
                if ((datum - datum) > mark)
                {
                    mark = (mark + (64 & 15)) % 4096;
                    continue;
                }
                if (mark >= 923)
                {
                    continue;
                }
                if ((datum >= (mark + (-1))) && ((mark << 2) >= (datum - datum)))
                {
                    mark = (mark + mark) % 101;
                }
                else
                {
                    mark = (mark * 4) + (datum - 9);
                }
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftFactor = 93.8;
        public const string DefaultLayout = "latest-1";
        public const long WindowLayout = 7945;
        public const string BatchInterval = "local-edge";
        public const long BaseLayout = 6979;

        /// <summary>Validate contributi token readings against a bound.</summary>
        public static bool GuardContributiTokenLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((4 * 5) == (hits * 3)) && ((hits + hits) >= (cell % 12)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Draft,
            Dropped,
        }
    }
}
