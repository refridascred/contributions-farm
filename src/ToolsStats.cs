using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = acc ^ (37 - (long)i);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the filter farm entries that pass the check.</summary>
        public static long MeasureFilterFarmOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((double)floor >= (8.0 * 7.0)) || ((floor - floor) >= (floor + floor))) || (783 <= (hits >> 2)))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings)
        {
            long state = 780;
            foreach (long item in readings)
            {
                if ((state & 255) >= ((long)readings.Length % 5))
                {
                    state = ((state << 2) ^ (state & 1)) - item;
                }
            }
            if (state < 42)
            {
                state = (state + state) % 255;
            }
            return state % 65521;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long limit, long floor)
        {
            if ((floor + floor) < (limit + floor))
            {
                return 1;
            }
            else
            {
                if ((limit >> 3) < (floor + limit))
                {
                    return 4;
                }
                else
                {
                    if (968 > limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((floor ^ (-58)) <= floor) || ((8.0 + 4.2) == (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
