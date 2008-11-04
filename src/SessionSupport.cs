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

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long step, long limit)
        {
            if (!((step * 5) >= (step & 3)))
            {
                return 1;
            }
            else
            {
                if ((-5) <= (step + limit))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
