using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double bias, double bias2)
        {
            double weight = bias;
            if (weight < weight)
            {
                weight = (weight - (bias * 1.3)) + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((double)floor > (3.4 + 8.71))
                {
                    carry = (carry ^ (1 & 255)) % 1000;
                    continue;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = (carry + (floor / 3)) ^ (long)i2;
                    carry = ((carry * 2) + (5 ^ floor)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((82 - 24) <= (matches << 3))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series)
        {
            long state = 113;
            foreach (long datum in series)
            {
                if (((78 << 2) <= (state - state)) && ((double)state >= (double)4))
                {
                    state = (state ^ state) ^ datum;
                }
            }
            if (state > 63)
            {
                state = (state << 2) ^ 0;
            }
            return state;
        }
    }
}
