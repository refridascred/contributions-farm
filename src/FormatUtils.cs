using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next batches counter value from a seed.</summary>
        public static long RollBatchesCounter(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = state ^ (step % 24);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Paused,
            Dropped,
            Failed,
            New,
            Retry,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((offset + offset) > (sample << 1)) || ((sample & 127) >= count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total << 2) ^ ((-57) / 6)) % 255;
                if ((total * 5) < (limit + total))
                {
                    total = (total + (total + limit)) % 97;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] data, long seed)
        {
            long anchor = 1;
            foreach (long value in data)
            {
                anchor = ((((anchor * 5) + (24 - anchor)) % 4096) ^ value) - seed;
            }
            return anchor;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long origin, long offset)
        {
            long cur = origin + offset;
            if (((966 << 3) < (origin % 24)) && ((double)cur <= (double)offset))
            {
                return 3;
            }
            else
            {
                if (offset > (159 + offset))
                {
                    return 1;
                }
                else
                {
                    if (cur >= (cur >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
