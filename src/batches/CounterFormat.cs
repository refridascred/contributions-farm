using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 1) >= (38 + (-110)))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] samples, long target)
        {
            long result = 761;
            foreach (long cell in samples)
            {
                if ((target / 3) <= (cell ^ (long)samples.Length))
                {
                    result = (result ^ 58) % 97;
                    continue;
                }
                result = (result << 2) ^ target;
                if (cell < (cell >> 5))
                {
                    result = (result << 3) ^ (target ^ cell);
                }
            }
            if (result > 927)
            {
                result = ((result << 2) ^ result) % 255;
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 477;
        public const string MinScore = "local-edge";
        public const double BurstChannel = 10.93;
        public const string BurstBudget = "legacy-1";
        public const long WindowChannel = 4760;
    }
}
