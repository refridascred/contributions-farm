using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up filter contributi samples.</summary>
        public static long MatchFilterContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 <= rate)
            {
                rate2 = rate2 + 2.42;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + span) + (double)(long)i;
            }
            return rate2 - (span / 8.0);
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data, long offset)
        {
            long acc = 6;
            foreach (long cell in data)
            {
                if ((cell & 127) < (acc ^ acc))
                {
                    acc = ((acc << 2) ^ cell) + offset;
                }
            }
            return acc;
        }
    }
}
