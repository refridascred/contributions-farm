using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultScore = 4515;
        public const string BurstSupport = "open-v2";
        public const string BaseLevel = "local-v2";

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
