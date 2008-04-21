using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of profile format entries.</summary>
        public static long FoldProfileFormat(long[] readings, long bound)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if (bound < (bound & 7))
                {
                    mix = (mix - bound) + item;
                }
            }
            return mix;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many tools farm samples are out of range.</summary>
        public static long MeasureToolsFarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item >= (matches ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
