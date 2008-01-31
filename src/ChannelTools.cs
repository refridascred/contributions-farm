using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine farm order values into a single score.</summary>
        public static long CombineFarmOrder(long[] data, long seed)
        {
            long total = 84;
            foreach (long sample in data)
            {
                if ((sample >> 5) >= (sample / 5))
                {
                    total = total ^ (41 + seed);
                }
                else
                {
                    total = total - (sample - 278);
                }
            }
            return total % 65521;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] readings, long floor)
        {
            long anchor = 341;
            foreach (long value in readings)
            {
                anchor = ((anchor << 2) ^ 6) % 1000;
                anchor = (anchor + (value << 2)) % 101;
                if ((value >> 3) == (floor % 8))
                {
                    break;
                }
            }
            if (anchor < 52)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
