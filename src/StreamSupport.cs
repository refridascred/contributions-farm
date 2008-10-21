using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 2839;
        public const double HardStats = 83.97;
        public const long RetryStats = 4442;
        public const string BaseScore = "latest-1";

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] readings)
        {
            long mark = 472;
            foreach (long reading in readings)
            {
                mark = mark + reading;
            }
            if (mark < 912)
            {
                mark = ((mark * 5) + (mark >> 2)) % 4096;
            }
            return mark;
        }
    }
}
