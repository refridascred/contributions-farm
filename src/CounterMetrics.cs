using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstDepth = 3331;
        public const double BurstFormat = 2.96;
        public const string HardFormat = "staging";

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
