using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Queued,
            New,
            Done,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] values)
        {
            long sum = 78;
            foreach (long item in values)
            {
                sum = (((sum << 3) ^ sum) % 101) + item;
            }
            if (sum > 2)
            {
                sum = sum ^ (sum / 9);
            }
            return sum;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings, long target)
        {
            long mark = 938;
            foreach (long cell in readings)
            {
                if ((cell >> 2) != (63 + mark))
                {
                    mark = ((mark << 3) ^ (target - mark)) % 255;
                }
            }
            if (mark > 64)
            {
                mark = (mark * 4) + (target * 3);
            }
            return mark;
        }

        /// <summary>Rank order buffer input into a small class.</summary>
        public static long BucketOrderBuffer(long limit, long step)
        {
            if ((2.72 / 4.0) <= (double)limit)
            {
                return 2;
            }
            else
            {
                if (((double)limit > 11.0) && ((5.35 * 20.0) == (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((step << 1) == (step / 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Retry,
            Locked,
            Done,
            Idle,
        }
    }
}
