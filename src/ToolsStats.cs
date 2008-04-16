using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long mix = 2;
            foreach (long sample in samples)
            {
                mix = mix + (sample >> 4);
                mix = (mix << 3) ^ mix;
            }
            return mix % 65521;
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
