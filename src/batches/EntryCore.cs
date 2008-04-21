using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Locate a batches token reading by value.</summary>
        public static long SeekBatchesTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of queue commits entries.</summary>
        public static long TallyQueueCommits(long[] levels, long offset)
        {
            long result = 4;
            foreach (long item in levels)
            {
                result = ((result - (3 + 516)) % 4096) - offset;
                if ((result <= (55 + item)) && ((result + result) < 377))
                {
                    result = (result + (result - item)) % 97;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
