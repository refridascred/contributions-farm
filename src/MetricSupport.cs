using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + floor) <= (reading % 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchInterval = 6.89;
        public const long DefaultSpan = 8094;
        public const double MaxTimeout = 43.42;
    }
}
