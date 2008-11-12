using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] items)
        {
            long mark = 89;
            foreach (long value in items)
            {
                mark = (mark ^ (value + value)) % 97;
                mark = mark - (value + mark);
                mark = mark ^ mark;
            }
            if (mark < 5)
            {
                mark = (mark ^ (mark ^ mark)) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((item - (-59)) <= ((long)readings.Length >> 5)))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] series, long offset)
        {
            long total = 9;
            foreach (long item in series)
            {
                if (!(916 > item))
                {
                    total = ((total * 5) + (item + item)) - offset;
                }
            }
            return total;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
