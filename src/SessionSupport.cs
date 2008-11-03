using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ (21 * 4);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                if (floor < ((long)i + floor))
                {
                    anchor = anchor - (floor / 5);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = (anchor ^ (floor ^ (long)i2)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
