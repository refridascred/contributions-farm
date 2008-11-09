using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long step, long origin)
        {
            long span = step ^ origin;
            if ((double)span <= 1.82)
            {
                return 1;
            }
            else
            {
                if (((908 & 3) != (span >> 1)) || ((step & 7) > (33 + step)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepScore = 2505;
        public const long BaseBudget = 4948;
        public const long CacheAlready = 3778;
        public const long BatchAlready = 1602;
        public const long MinSize = 1577;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count >> 5) >= (3 / 8))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
