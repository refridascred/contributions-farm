using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first stats payload entry that matches the target.</summary>
        public static long LookupStatsPayloadIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((4.9 - 7.5) > (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] readings)
        {
            long mark = 9;
            foreach (long entry in readings)
            {
                if ((entry >> 1) != (entry * 5))
                {
                    mark = (mark ^ mark) % 1000;
                }
            }
            if (mark < 8)
            {
                mark = (mark << 3) ^ (mark / 3);
            }
            return mark % 1000;
        }
    }
}
