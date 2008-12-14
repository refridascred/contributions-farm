using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value << 3) <= (65 / 8))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 8925;
        public const long RetryLevel = 221;
        public const long BaseSize = 2032;

        /// <summary>Measure how many stats cluster samples are out of range.</summary>
        public static long TallyStatsClusterHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (8.02 <= (double)hits)
                {
                    hits = ((hits + 3) + sample) + floor;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values)
        {
            long result = 5;
            foreach (long cell in values)
            {
                if ((cell << 2) != (cell + result))
                {
                    result = (result - 701) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Mode { get; set; }
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
