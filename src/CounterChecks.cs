using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result - (result - target)) + (long)i2;
                }
                result = (result << 2) ^ (target + 20);
                result = (result - (result * 3)) % 4096;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every counter editor entry stays within the limit.</summary>
        public static bool VerifyCounterEditorBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            Done,
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double ratio, double offset)
        {
            double rate = offset + (double)2;
            if (rate >= (offset / 9.0))
            {
                rate = (rate - 11.0) + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate + (double)(-34);
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long bound)
        {
            long delta = seed ^ bound;
            if ((10.0 / 2.0) >= (double)delta)
            {
                return 8;
            }
            else
            {
                if (delta >= (delta << 1))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
