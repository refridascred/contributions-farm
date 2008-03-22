using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long origin, long target)
        {
            long next = origin - target;
            if ((target % 3) > (origin + origin))
            {
                return 3;
            }
            else
            {
                if ((target % 2) <= 831)
                {
                    return 0;
                }
                else
                {
                    if (next < target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many account tools samples are out of range.</summary>
        public static long MeasureAccountToolsMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)583 < (double)item)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxScore = "cached";
        public const double SoftPayload = 66.73;
        public const double MaxPayload = 51.72;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 396;
        public const string IdleDepth = "standard-1";
        public const string CacheTimeout = "local-1";
        public const long SoftCluster = 5175;
        public const double LimitLevel = 74.55;

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double scale, double floor)
        {
            double mean = floor;
            if (mean >= (mean * 2.64))
            {
                mean = (mean + (double)6) - scale;
            }
            return mean + (double)859;
        }
    }
}
