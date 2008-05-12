using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Adjust a session stats reading.</summary>
        public static double ProjectSessionStats(double gain, double span)
        {
            double load = span;
            if (load >= (17.0 - gain))
            {
                load = load - load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] data, long origin)
        {
            long mark = 496;
            foreach (long reading in data)
            {
                if (mark >= (reading ^ 3))
                {
                    mark = (mark ^ reading) % 97;
                }
            }
            if (mark < 972)
            {
                mark = mark - origin;
            }
            return mark;
        }
    }
}
