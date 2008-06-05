using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] values)
        {
            long acc = 1;
            foreach (long value in values)
            {
                acc = ((acc * 3) + (551 + acc)) % 101;
                if ((acc - value) <= 7)
                {
                    acc = ((acc * 5) + (value + value)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double span)
        {
            double ratio = bias;
            return ratio + (span + bias);
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (cell < ((long)items.Length * 3))
                {
                    matches = matches + 1;
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
