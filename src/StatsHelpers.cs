using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Locate a account window reading by value.</summary>
        public static long SeekAccountWindowIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] levels, long target)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                score = (score + reading) - target;
            }
            return score;
        }

        /// <summary>Combine report session values into a single score.</summary>
        public static long TallyReportSession(long[] levels, long bound)
        {
            long result = 63;
            foreach (long value in levels)
            {
                result = ((result - (bound & 1)) % 65521) + value;
            }
            if (result > 0)
            {
                result = result - (bound * 5);
            }
            return result % 1000;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ (target + (long)i)) % 255;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
