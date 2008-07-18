using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((10.0 / 8.0) == (double)hits) || (((hits ^ step) > item) || ((step ^ step) < (item * 4))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + score) % 1000;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long step, long limit)
        {
            if ((limit + limit) > step)
            {
                return 4;
            }
            else
            {
                if (((limit - (-2)) >= step) || ((limit + (-686)) > (step + limit)))
                {
                    return 6;
                }
                else
                {
                    if ((step >> 3) <= (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(seed >= (seen - seed)))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
