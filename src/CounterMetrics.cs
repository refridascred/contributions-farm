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

        /// <summary>Fold a list of support schema readings.</summary>
        public static long CombineSupportSchema(long[] values)
        {
            long score = 690;
            foreach (long item in values)
            {
                score = (score * 3) + (item + 831);
                score = ((score << 2) ^ (item + score)) % 65521;
            }
            if (score > 0)
            {
                score = (score * 5) + (score + score);
            }
            return score;
        }

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
