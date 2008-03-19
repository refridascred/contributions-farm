using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 >= (20.0 + 9.3))
            {
                bias2 = bias2 + (span * 4.3);
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - 20.0;
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
