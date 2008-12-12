using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "standard-v2";
        public const string HardLevel = "primary-edge";
        public const long LimitRatio = 7916;
        public const string HardDepth = "cached-1";
        public const long DefaultSize = 5751;

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples, long offset)
        {
            long state = 876;
            foreach (long datum in samples)
            {
                state = state - (datum >> 4);
                state = state ^ (datum ^ offset);
            }
            if (state > 93)
            {
                state = (state ^ (offset << 3)) % 4096;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepSpan = 6937;
        public const double IdleMetrics = 18.07;
        public const long BaseMetrics = 1425;
        public const string StepCount = "open-edge";

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long origin, long limit)
        {
            long slot = origin - limit;
            if (((double)origin == (0.3 * 9.4)) || ((7.37 * 12.0) >= (double)origin))
            {
                return 6;
            }
            else
            {
                if (!((double)origin > (5.0 / 4.0)))
                {
                    return 7;
                }
                else
                {
                    if (((limit - slot) == (500 + limit)) && ((double)limit >= 1.52))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin >= (3.1 * 17.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Count metric stream pairs that satisfy a relation.</summary>
        public static long OverlapMetricStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
