using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Derive the next counter payload value from a seed.</summary>
        public static long DeriveCounterPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor + step) % 4096;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many command stream samples are out of range.</summary>
        public static long CountCommandStreamOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((long)data.Length <= (offset - matches))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] series, long seed)
        {
            long mix = 69;
            foreach (long value in series)
            {
                if ((value - value) < mix)
                {
                    mix = ((mix << 3) ^ value) - seed;
                }
                else
                {
                    mix = (mix ^ mix) % 101;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ (mix + mix)) % 4096;
            }
            return mix % 4096;
        }
    }
}
