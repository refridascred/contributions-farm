using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleCache = 27.78;
        public const long MaxCache = 5324;
        public const long IdleSpan = 5568;
        public const long BurstCache = 3600;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((cell / 9) >= cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
