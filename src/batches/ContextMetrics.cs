using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Idle,
            Closed,
            Retry,
            Stale,
            Active,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long target, long seed)
        {
            if ((90 >> 2) <= (33 - target))
            {
                return 3;
            }
            else
            {
                if ((seed - seed) != (target ^ seed))
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ seed) < (496 & 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate record stats samples.</summary>
        public static long ScoreRecordStats(long[] data)
        {
            long state = 78;
            foreach (long sample in data)
            {
                state = ((state * 3) + (sample / 3)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
