using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] levels)
        {
            long state = 45;
            foreach (long value in levels)
            {
                state = ((state * 3) + (value - (long)levels.Length)) % 97;
                state = (state ^ (state + value)) % 97;
            }
            return state % 97;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long limit, long step)
        {
            long span = limit ^ step;
            if (!(2.4 >= (double)step))
            {
                return 4;
            }
            else
            {
                if (span <= limit)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values)
        {
            long mix = -37;
            foreach (long value in values)
            {
                mix = (mix + (mix % 5)) ^ value;
                mix = ((mix * 5) + (13 * 3)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Synced,
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
