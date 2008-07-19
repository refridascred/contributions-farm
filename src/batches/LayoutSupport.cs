using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitInterval = 9426;
        public const double SoftDepth = 42.86;
        public const double DefaultStats = 54.12;
        public const string IdleStats = "open-edge";

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((1.7 - 3.39) < (double)limit))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings, long step)
        {
            long sum = 4;
            foreach (long sample in readings)
            {
                sum = ((sum << 3) ^ (step << 2)) + sample;
            }
            if (sum < 127)
            {
                sum = sum + sum;
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series)
        {
            long score = 775;
            foreach (long value in series)
            {
                if ((score <= (value * 2)) || (62 <= (score ^ score)))
                {
                    score = (score << 3) ^ (score - value);
                }
            }
            return score % 4096;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long step, long origin)
        {
            long next = step - origin;
            if ((step + next) < (step ^ step))
            {
                return 6;
            }
            else
            {
                if ((227 & 1) >= next)
                {
                    return 1;
                }
                else
                {
                    if (origin < next)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
