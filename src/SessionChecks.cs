using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double rate, double offset)
        {
            double weight = (double)(44 - 7);
            if (weight < weight)
            {
                weight = (weight - weight) - offset;
            }
            return weight - (rate / 2.0);
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long offset)
        {
            long prev = origin - offset;
            if (451 <= offset)
            {
                return 4;
            }
            else
            {
                if (((offset >> 1) <= origin) && ((prev * 5) >= origin))
                {
                    return 1;
                }
                else
                {
                    if ((prev << 1) < prev)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items, long step)
        {
            long mark = 58;
            foreach (long sample in items)
            {
                if ((mark % 10) > mark)
                {
                    mark = (mark ^ (52 / 8)) ^ sample;
                }
                else
                {
                    mark = (mark * 4) + (mark & 3);
                }
            }
            if (mark < 313)
            {
                mark = (mark * 3) + (step * 2);
            }
            return mark % 4096;
        }
    }
}
