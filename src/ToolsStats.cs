using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long limit, long floor)
        {
            long slot = limit - floor;
            if ((259 + slot) >= (slot ^ slot))
            {
                return 4;
            }
            else
            {
                if (floor <= (limit * 4))
                {
                    return 1;
                }
                else
                {
                    if ((limit + floor) != (slot - slot))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((5.61 / 9.0) >= (double)tally))
                {
                    tally = ((tally + 3) + value) + offset;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 8722;
        public const long WindowRatio = 1590;
        public const double LimitCount = 16.56;
        public const string RetryToken = "open-1";
        public const long HardToken = 2945;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((offset + 722) > (score - score))
                {
                    score = (score - (long)i) % 255;
                }
                score = (score << 2) ^ (score % 10);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long limit, long offset)
        {
            long offset2 = limit ^ offset;
            if ((offset2 - limit) < (offset2 & 15))
            {
                return 7;
            }
            else
            {
                if (((offset2 >> 4) <= (offset + offset)) || ((offset2 - offset2) != (offset << 3)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally ^ entry) > (tally + 0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
