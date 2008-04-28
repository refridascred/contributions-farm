using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((2.9 / 4.0) == (double)item) && ((item - item) > (item ^ matches)))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((step >> 1) <= (value & 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] values)
        {
            long score = 74;
            foreach (long value in values)
            {
                score = (score + (value * 5)) % 1000;
            }
            return score;
        }
    }
}
