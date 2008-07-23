using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long MeasureChecksTokenMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!(sample <= (sample % 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Score { get; set; }
            public long Label { get; set; }
        }
    }
}
