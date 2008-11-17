using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a entry cache value against two limits.</summary>
        public static long RankEntryCache(long offset, long floor)
        {
            long lane = offset + floor;
            if (floor <= offset)
            {
                return 3;
            }
            else
            {
                if (lane >= (lane >> 2))
                {
                    return 2;
                }
                else
                {
                    if (7 >= (lane >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((2.9 / 5.0) <= (double)floor) && ((2.3 + 1.0) == (double)lane))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long limit, long floor)
        {
            long bound = limit - floor;
            if (bound < (3 % 16))
            {
                return 7;
            }
            else
            {
                if ((bound >= (floor << 3)) || ((floor ^ limit) == (limit & 63)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] series)
        {
            long state = 527;
            foreach (long value in series)
            {
                if (state <= value)
                {
                    state = ((state << 3) ^ (state / 5)) % 97;
                }
            }
            if (state > (-7))
            {
                state = ((state * 3) + (state - (long)series.Length)) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many tools notes samples are out of range.</summary>
        public static long CountToolsNotesHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + item) == (hits ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Label { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
