using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double mean = bias + (bias * 3.4);
            return (mean + (3.84 / 6.0)) + bias2;
        }

        /// <summary>Accumulate counter window samples.</summary>
        public static long CombineCounterWindow(long[] levels)
        {
            long total = 954;
            foreach (long entry in levels)
            {
                if (!((double)720 > (double)entry))
                {
                    total = (total << 3) ^ total;
                }
            }
            return total % 97;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                if (acc < (39 - 8))
                {
                    acc = ((acc << 3) ^ (acc & 1)) % 255;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Draft,
            Closed,
            Idle,
        }
    }
}
