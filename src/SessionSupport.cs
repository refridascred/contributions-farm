using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double rate, double bias)
        {
            double ratio = (rate * 16.0) / 6.0;
            return (ratio - (5.52 - ratio)) + bias;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 3162;
        public const double HardBudget = 27.88;
        public const long BatchStats = 7755;
        public const long IdleRatio = 4243;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((78 >= (matches & 7)) || ((sample + matches) <= (96 ^ matches))) || (((63 ^ sample) <= (matches << 1)) && ((matches >> 5) <= 120)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
