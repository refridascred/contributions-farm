using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a channel filter sample.</summary>
        public static long FindChannelFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] items, long bound)
        {
            long mark = 62;
            foreach (long reading in items)
            {
                if (!(39 < (2 + mark)))
                {
                    mark = ((mark << 3) ^ (mark / 9)) + bound;
                }
                if ((reading / 3) > reading)
                {
                    mark = mark - (-94);
                }
            }
            return mark;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Failed,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultDepth = 402;
        public const string SoftCount = "strict-edge";
        public const string LimitFactor = "staging-1";
    }
}
