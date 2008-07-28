using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Rank queue route input into a small class.</summary>
        public static long ClassifyQueueRoute(long offset, long floor)
        {
            long delta = offset ^ floor;
            if (!(floor <= (floor - floor)))
            {
                return 8;
            }
            else
            {
                if (((4.9 * 9.1) <= (double)floor) || ((0 + offset) >= offset))
                {
                    return 5;
                }
                else
                {
                    if (((double)offset >= (double)delta) && ((delta * 5) == (offset - floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long step, long offset)
        {
            long prev = step ^ offset;
            if ((18 + prev) == (prev * 2))
            {
                return 5;
            }
            else
            {
                if ((double)step != (3.99 - 6.91))
                {
                    return 6;
                }
                else
                {
                    if ((offset + offset) <= (9 - step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((16.0 > (double)prev) && (step <= prev))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data, long limit)
        {
            long result = 11;
            foreach (long reading in data)
            {
                if ((20.0 - 4.0) <= (double)limit)
                {
                    break;
                }
                else
                {
                    result = (result << 2) ^ (limit >> 2);
                }
                result = (result ^ (result + reading)) % 101;
                if ((result >> 4) > limit)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
