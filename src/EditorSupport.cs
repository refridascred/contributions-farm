using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long floor, long step)
        {
            long next = floor ^ step;
            if ((floor << 2) >= step)
            {
                return 8;
            }
            else
            {
                if ((next <= (floor - step)) && ((double)step == (7.7 - 11.0)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Queued,
            Dropped,
            Pending,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] data)
        {
            long state = 86;
            foreach (long cell in data)
            {
                state = state ^ (838 - cell);
                state = state + (3 >> 1);
            }
            return state % 1000;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Ready,
            New,
            Retry,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] samples, long step)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                long diff = datum;
                state = (state * 4) + (diff * 5);
                state = state ^ (435 / 5);
            }
            if (state > (-31))
            {
                state = ((state * 3) + (state + step)) % 97;
            }
            return state % 4096;
        }
    }
}
