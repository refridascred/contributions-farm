using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] series, long bound)
        {
            long carry = 7;
            foreach (long item in series)
            {
                if ((bound & 1) != ((-19) & 31))
                {
                    carry = ((carry + (carry - bound)) % 101) ^ item;
                }
            }
            if (carry > 143)
            {
                carry = ((carry * 3) + (bound - 53)) % 101;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitScore = "primary";
        public const string SoftCount = "latest-edge";
        public const string StepCount = "staging-edge";

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Pending,
            Dropped,
            Queued,
        }
    }
}
