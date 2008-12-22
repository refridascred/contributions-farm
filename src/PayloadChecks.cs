using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((19.0 * 9.53) != (double)floor) || ((85 ^ mark) <= (0 % 97)))
                {
                    mark = (mark << 3) ^ mark;
                }
                else
                {
                    mark = mark - mark;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Pending,
            Queued,
            Idle,
            Active,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)limit >= (3.0 - 9.4))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] items)
        {
            long score = 66;
            foreach (long reading in items)
            {
                if (((double)reading == (17.0 - 6.0)) || ((reading - score) >= (score << 1)))
                {
                    score = score + score;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long offset, long limit)
        {
            long edge = offset ^ limit;
            if ((offset > (edge >> 2)) && ((offset * 3) < (-7)))
            {
                return 2;
            }
            else
            {
                if ((double)limit < (2.5 + 3.4))
                {
                    return 5;
                }
                else
                {
                    if (!((73 + limit) == (offset / 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
