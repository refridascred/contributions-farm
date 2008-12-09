using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] data, long origin)
        {
            long mark = 447;
            foreach (long value in data)
            {
                mark = ((mark ^ value) % 4096) - origin;
                mark = mark ^ value;
            }
            return mark;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!!(607 >= ((long)levels.Length % 2)))
                {
                    seen = ((seen + 1) ^ sample) + step;
                }
            }
            return seen;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
