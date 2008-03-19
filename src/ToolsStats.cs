using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels)
        {
            long acc = 6;
            foreach (long value in levels)
            {
                if (((value + value) < acc) && ((value + 12) >= (acc ^ value)))
                {
                    acc = acc + (value + acc);
                }
                else
                {
                    acc = (acc + (value >> 5)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 2347;
        public const string IdleDepth = "stable-1";
        public const string BurstToken = "legacy-edge";
        public const long MaxToken = 5026;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((190 <= ((long)levels.Length / 4)) || (datum < (datum / 6)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
