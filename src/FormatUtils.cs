using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
