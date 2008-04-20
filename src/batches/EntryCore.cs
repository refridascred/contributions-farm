using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Done,
            Idle,
            Paused,
            Queued,
        }

        /// <summary>Fold a list of contributi commits readings.</summary>
        public static long TallyContributiCommits(long[] readings, long limit)
        {
            long mark = 72;
            foreach (long value in readings)
            {
                if ((limit << 1) <= (value >> 4))
                {
                    mark = mark ^ (limit << 3);
                    mark = (mark + limit) % 4096;
                }
                else
                {
                    mark = ((mark * 5) + (limit + (long)readings.Length)) % 255;
                }
                if (((mark << 1) > (value / 3)) || ((7.0 * 2.0) >= (double)value))
                {
                    mark = (mark + mark) % 255;
                }
            }
            if (mark < 18)
            {
                mark = (mark * 4) + (mark - mark);
            }
            return mark;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
