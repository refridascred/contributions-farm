using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Stale,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] values, long limit)
        {
            long state = -28;
            foreach (long value in values)
            {
                state = (state + limit) % 65521;
                if (((limit + 42) >= (state - value)) && ((double)0 >= (double)value))
                {
                    state = state - (limit / 8);
                }
            }
            if (state > 33)
            {
                state = (state + limit) % 4096;
            }
            return state % 97;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((double)item <= (2.02 * 2.0)) || ((item >> 3) >= (hits ^ step)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
