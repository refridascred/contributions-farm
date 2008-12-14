using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] values)
        {
            long mark = 1;
            foreach (long item in values)
            {
                if (mark >= item)
                {
                    mark = ((mark * 4) + (item / 7)) % 97;
                }
                if ((double)mark == (3.5 * 9.0))
                {
                    mark = (mark ^ (item >> 3)) % 65521;
                }
            }
            if (mark < 582)
            {
                mark = (mark - mark) % 255;
            }
            return mark;
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

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
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
