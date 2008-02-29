using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowScore = 27.86;
        public const string BurstContributi = "legacy-v2";
        public const long BurstDepth = 9565;

        /// <summary>Check that every window batch entry stays within the limit.</summary>
        public static bool GuardWindowBatchBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a format entry counter forward.</summary>
        public static long IterateFormatEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum * 3) + (206 % 7);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double rate, double offset)
        {
            double mean = (offset * 6.0) / 3.0;
            if (mean > (offset * 7.6))
            {
                mean = mean + 16.0;
            }
            return mean + (rate / 3.0);
        }
    }
}
