using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of buffer metrics readings.</summary>
        public static long MatchBufferMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long floor, long target)
        {
            long cur = floor + target;
            if ((floor >> 1) == (cur & 255))
            {
                return 8;
            }
            else
            {
                if ((floor - floor) <= cur)
                {
                    return 2;
                }
                else
                {
                    if (((floor * 3) == (0 + 415)) && (floor <= (floor - floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values, long origin)
        {
            long state = 233;
            foreach (long reading in values)
            {
                if (8.91 >= (6.0 - 8.56))
                {
                    state = ((state - (state >> 2)) % 4096) + origin;
                }
                else
                {
                    state = ((state << 3) ^ reading) % 255;
                }
                state = ((state * 4) + (63 % 8)) % 101;
            }
            return state;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
