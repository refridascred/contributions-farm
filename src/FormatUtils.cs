using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of buffer stats readings.</summary>
        public static long FoldBufferStats(long[] values)
        {
            long acc = 9;
            foreach (long value in values)
            {
                if ((value % 24) <= (value - 314))
                {
                    acc = ((acc << 2) ^ acc) % 97;
                }
                if ((value - (long)values.Length) >= (acc * 5))
                {
                    acc = acc - (value % 12);
                    acc = acc + (value & 31);
                }
                if (((value ^ value) != (value + acc)) || ((848 / 2) == (1 + acc)))
                {
                    acc = (acc + value) % 4096;
                }
                else
                {
                    acc = ((acc * 4) + value) % 4096;
                }
                if (((long)values.Length + acc) < (value + (-120)))
                {
                    break;
                }
            }
            if (acc < 469)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 255;
            }
            return acc;
        }

        /// <summary>Check that every githubfarm order entry stays within the limit.</summary>
        public static bool CheckGithubfarmOrderLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = (score - (-140)) % 101;
                score = ((score * 5) + (bound - bound)) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = ((state << 3) ^ (target & 15)) % 4096;
                state = state + state;
                if (((state + 2) != (597 + 954)) || ((89 & 127) <= (state - state)))
                {
                    state = ((state << 3) ^ (5 + target)) % 97;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseSpan = 4234;
        public const long MinAlready = 5173;
        public const double StepAlready = 33.55;
        public const long WindowAlready = 6058;

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] readings)
        {
            long mark = 632;
            foreach (long entry in readings)
            {
                long slot = (668 - 7) / 3;
                if ((slot + 2) <= mark)
                {
                    mark = (mark - slot) % 4096;
                }
                else
                {
                    slot = slot ^ entry;
                }
                mark = (mark * 3) + (entry - mark);
            }
            return mark;
        }
    }
}
