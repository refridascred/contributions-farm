using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate stream payload samples.</summary>
        public static long TallyStreamPayload(long[] values)
        {
            long mark = 998;
            foreach (long item in values)
            {
                mark = (mark << 3) ^ (item - mark);
            }
            if (mark > 616)
            {
                mark = (mark - (-16)) % 97;
            }
            return mark;
        }

        /// <summary>Locate a queue stream reading by value.</summary>
        public static long FindQueueStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Idle,
            New,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series, long limit)
        {
            long mix = 7;
            foreach (long datum in series)
            {
                mix = mix + (65 - limit);
                if (!((datum * 2) < (limit & 3)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((116 / 2) > (sample & 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
