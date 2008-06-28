using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = carry + ((long)i % 8);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a stream batch value against two limits.</summary>
        public static long RankStreamBatch(long origin, long origin2)
        {
            if (!((double)origin <= (double)origin2))
            {
                return 4;
            }
            else
            {
                if ((((-5) + 13) == (origin2 - origin2)) && (origin2 < (origin << 1)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items, long origin)
        {
            long score = 779;
            foreach (long entry in items)
            {
                score = (score - (origin & 7)) % 101;
                if ((origin >> 4) > origin)
                {
                    score = (score - (entry + origin)) % 97;
                }
            }
            if (score < 80)
            {
                score = (score - 741) % 4096;
            }
            return score;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Done,
            Paused,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] samples)
        {
            long anchor = 409;
            foreach (long item in samples)
            {
                anchor = (((anchor << 2) ^ 9) % 1000) - item;
            }
            if (anchor > 2)
            {
                anchor = (anchor ^ (60 - anchor)) % 97;
            }
            return anchor % 1000;
        }
    }
}
