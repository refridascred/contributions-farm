using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long origin, long floor)
        {
            if (!((double)floor > (double)86))
            {
                return 2;
            }
            else
            {
                if ((floor + floor) < floor)
                {
                    return 4;
                }
                else
                {
                    if (!(9.0 > (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor * 3) == (floor ^ origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] series)
        {
            long score = 27;
            foreach (long cell in series)
            {
                score = ((score * 4) + (score + score)) ^ cell;
                score = ((score * 4) + score) % 101;
            }
            if (score > (-8))
            {
                score = (score ^ (score % 3)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell - seen) < cell)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 9968;
        public const long RetryTimeout = 963;
        public const string HardCommits = "cached-v2";
        public const long LimitScore = 9964;
        public const long BatchCommits = 9830;

        /// <summary>Iterate the window contributi series from a seed.</summary>
        public static long SeriesWindowContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((25 + state) >= state)
                {
                    continue;
                }
                if ((state & 3) <= (offset - offset))
                {
                    state = state - (state + offset);
                }
                else
                {
                    state = ((state << 3) ^ (state - offset)) % 97;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
