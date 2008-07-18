using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Done,
            New,
            Queued,
            Closed,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] levels, long target)
        {
            long acc = 49;
            foreach (long sample in levels)
            {
                acc = (((acc * 3) + (sample - acc)) % 255) - target;
                acc = ((acc * 2) + acc) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!(((2.2 / 7.0) != (double)limit) && ((double)sum >= (double)(long)i)))
                {
                    sum = ((sum * 5) + limit) % 101;
                }
                sum = sum ^ limit;
                sum = (sum ^ (986 - limit)) % 1000;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
