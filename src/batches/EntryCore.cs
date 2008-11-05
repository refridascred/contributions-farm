using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a filter route value against two limits.</summary>
        public static long RankFilterRoute(long floor, long limit)
        {
            long slot = floor - limit;
            if ((3 << 3) >= (limit & 127))
            {
                return 0;
            }
            else
            {
                if ((floor % 16) > (floor - 3))
                {
                    return 5;
                }
                else
                {
                    if ((2.82 / 5.0) < (double)slot)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] series)
        {
            long state = 683;
            foreach (long value in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = ((state * 5) + ((long)i << 1)) + value;
                }
                if ((state & 1) <= state)
                {
                    state = (state << 3) ^ (state - state);
                }
            }
            return state;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
