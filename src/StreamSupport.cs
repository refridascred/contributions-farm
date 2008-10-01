using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc << 3) ^ (acc + (long)i)) % 101;
                acc = (acc + (seed + 6)) % 1000;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] readings)
        {
            long mark = 64;
            foreach (long datum in readings)
            {
                mark = mark + (datum ^ datum);
                if ((double)mark < (0.27 / 4.0))
                {
                    mark = ((mark << 2) ^ mark) % 65521;
                }
                if ((double)datum >= (4.42 - 14.0))
                {
                    mark = (mark + (mark / 9)) % 1000;
                }
            }
            return mark % 97;
        }
    }
}
