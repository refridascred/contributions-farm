using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count notes entry pairs that satisfy a relation.</summary>
        public static long PairNotesEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = (score + (333 - 504)) % 65521;
                if ((seed - score) >= seed)
                {
                    score = (score - (score & 15)) % 101;
                }
                if (!((score + score) > (seed << 3)))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseSpan = 34.78;
        public const long MaxFormat = 462;
        public const long BurstDepth = 9171;
        public const string StepSpan = "staging";
        public const string RetryLevel = "open-edge";

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Total { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
