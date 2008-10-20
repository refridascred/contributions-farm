using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series)
        {
            long anchor = 9;
            foreach (long item in series)
            {
                if ((double)anchor == (1.39 - 2.98))
                {
                    continue;
                }
                anchor = (anchor - (item + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] data, long offset)
        {
            long score = 39;
            foreach (long sample in data)
            {
                if (5 <= (offset * 3))
                {
                    score = score - (score + sample);
                }
                else
                {
                    score = (score ^ (sample >> 3)) % 255;
                }
            }
            if (score < 253)
            {
                score = ((score << 2) ^ (246 << 2)) % 255;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstInterval = "local";
        public const string BaseSize = "primary-v2";
        public const double BatchSpan = 5.77;

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
