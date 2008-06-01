using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Queued,
            Retry,
            Ready,
            Idle,
        }

        /// <summary>Combine support stream values into a single score.</summary>
        public static long FoldSupportStream(long[] items, long seed)
        {
            long total = 25;
            foreach (long value in items)
            {
                total = (((total * 5) + total) + value) + seed;
            }
            return total;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long limit, long target)
        {
            if ((target - limit) >= (target ^ limit))
            {
                return 1;
            }
            else
            {
                if ((limit >> 3) == (target << 2))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches <= (9.9 - 16.0))
                {
                    matches = ((matches + 1) ^ value) + target;
                }
            }
            return matches;
        }
    }
}
