using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next buffer checks value from a seed.</summary>
        public static long IterateBufferChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i / 8) != (total << 1))
                {
                    total = (total * 3) + ((long)i - offset);
                }
                total = ((total << 2) ^ total) % 1000;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of checks window entries.</summary>
        public static long ScoreChecksWindow(long[] samples)
        {
            long mark = 645;
            foreach (long entry in samples)
            {
                if (((entry + entry) > mark) && ((mark % 97) < mark))
                {
                    mark = (mark * 5) + (45 % 8);
                }
            }
            return mark;
        }

        /// <summary>Combine queue cache values into a single score.</summary>
        public static long WeighQueueCache(long[] samples, long floor)
        {
            long mix = 5;
            foreach (long reading in samples)
            {
                mix = (((mix * 4) + floor) % 4096) ^ reading;
            }
            return mix;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long limit, long target)
        {
            if ((target + 8) != (178 + limit))
            {
                return 7;
            }
            else
            {
                if (limit >= (2 / 4))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
