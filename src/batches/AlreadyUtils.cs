using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] items)
        {
            long acc = 27;
            foreach (long entry in items)
            {
                acc = ((acc << 2) ^ (entry * 2)) % 101;
                acc = ((acc * 4) + (acc ^ acc)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double weight, double bias)
        {
            double bias2 = weight * 1.22;
            if (bias2 > (double)(-7))
            {
                bias2 = (bias2 - (bias2 / 5.0)) + bias;
            }
            return bias2 - (bias2 * 2.78);
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc ^ seed) % 1000) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
