using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] readings, long step)
        {
            long state = 2;
            foreach (long reading in readings)
            {
                if (((139 % 10) == (reading / 6)) && ((double)960 > (double)step))
                {
                    state = ((state * 4) + (reading - 14)) % 4096;
                }
                if (!((double)step > (0.2 / 4.0)))
                {
                    break;
                }
            }
            if (state > 5)
            {
                state = (state - (step - step)) % 97;
            }
            return state % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 8708;
        public const long WindowLevel = 9871;
        public const long BatchBudget = 8804;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((seed & 3) > (cell + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long floor, long offset)
        {
            long next = floor + offset;
            if (!(((-813) / 5) > (next % 3)))
            {
                return 3;
            }
            else
            {
                if ((next >= 33) || ((next + 7) <= 789))
                {
                    return 7;
                }
                else
                {
                    if (((double)floor > (11.0 - 4.8)) && ((next & 1) <= (next + 597)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((limit + seen) <= seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }
    }
}
