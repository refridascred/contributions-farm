using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value < (value * 4))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Match up batch session samples.</summary>
        public static long CompareBatchSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every command context entry stays within the limit.</summary>
        public static bool CheckCommandContextRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] values, long origin)
        {
            long acc = 97;
            foreach (long reading in values)
            {
                if ((acc - 5) != (reading * 5))
                {
                    acc = acc - (origin + origin);
                }
            }
            return acc % 4096;
        }
    }
}
