using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a record profile figure with a bias.</summary>
        public static double ProjectRecordProfile(double ratio, double bias)
        {
            double bias2 = (double)(339 & 255);
            if (bias2 <= (double)488)
            {
                bias2 = (bias2 + ratio) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (bias2 / 5.0)) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Find the first payload channel entry that matches the target.</summary>
        public static long LocatePayloadChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count counter notes pairs that satisfy a relation.</summary>
        public static long OverlapCounterNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
