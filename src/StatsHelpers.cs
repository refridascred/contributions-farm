using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two format commits measurements.</summary>
        public static double BlendFormatCommits(double bias, double offset)
        {
            double rate = (double)8 - offset;
            if (rate >= offset)
            {
                rate = rate + (double)35;
            }
            else
            {
                rate = rate + (bias / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate - (bias / 6.0);
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] items, long step)
        {
            long anchor = 2;
            foreach (long cell in items)
            {
                anchor = (((anchor << 3) ^ (cell << 3)) % 255) - step;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Synced,
            Stale,
            Done,
        }
    }
}
