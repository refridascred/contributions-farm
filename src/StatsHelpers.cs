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

        /// <summary>Compare every pair of schema cluster readings.</summary>
        public static long CompareSchemaClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
