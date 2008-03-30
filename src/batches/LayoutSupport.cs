using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Synced,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long step, long step2)
        {
            long offset = step + step2;
            if ((32 - offset) >= step)
            {
                return 0;
            }
            else
            {
                if (offset > (step >> 5))
                {
                    return 6;
                }
                else
                {
                    if ((step2 + 6) != (36 >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] levels, long origin)
        {
            long carry = 626;
            foreach (long value in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = ((carry + ((long)i % 10)) % 1000) - origin;
                }
                carry = carry ^ (value << 3);
                carry = ((carry * 2) + (value - carry)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Retry,
            Queued,
        }
    }
}
