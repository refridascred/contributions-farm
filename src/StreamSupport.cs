using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] values, long limit)
        {
            long acc = -38;
            foreach (long datum in values)
            {
                if ((5.9 / 7.0) != (double)datum)
                {
                    acc = ((acc << 2) ^ (419 + acc)) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ (372 * 4)) % 65521;
                }
                if ((limit - limit) >= (datum % 60))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next queue record value from a seed.</summary>
        public static long SeriesQueueRecord(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i * 3) >= state)
                {
                    state = (state + ((long)i - origin)) % 255;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] series, long bound)
        {
            long total = 8;
            foreach (long sample in series)
            {
                total = ((total - (total + sample)) % 97) + bound;
            }
            if (total > 23)
            {
                total = total + (total * 4);
            }
            return total % 65521;
        }
    }
}
