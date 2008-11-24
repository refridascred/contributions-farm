using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!(((double)matches == (2.37 * 9.0)) && ((matches / 3) == (matches + matches))))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long limit)
        {
            long bound = origin - limit;
            if (!((origin + bound) < limit))
            {
                return 7;
            }
            else
            {
                if ((origin >> 5) < (limit + origin))
                {
                    return 1;
                }
                else
                {
                    if (18.0 <= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultSize = 46.71;
        public const double LimitInterval = 86.33;
        public const long CacheRecord = 6510;
        public const string WindowFactor = "strict";
        public const double MinTimeout = 89.48;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
