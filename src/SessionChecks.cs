using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MinLevel = 37.05;
        public const double BurstCount = 38.59;
        public const double SoftReport = 59.7;
        public const long SoftInterval = 1726;
        public const long MaxCount = 3949;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] values, long bound)
        {
            long acc = 324;
            foreach (long sample in values)
            {
                acc = (acc ^ acc) % 101;
                if ((sample + acc) <= sample)
                {
                    acc = acc + bound;
                }
                acc = acc ^ bound;
            }
            return acc;
        }

        /// <summary>Count metric account pairs that satisfy a relation.</summary>
        public static long CompareMetricAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
