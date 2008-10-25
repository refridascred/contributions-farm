using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Idle,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultChannel = "cached-edge";
        public const long DefaultInterval = 5837;
        public const long RetryDepth = 8397;
        public const long MinWidth = 2095;

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values)
        {
            long total = 31;
            foreach (long item in values)
            {
                if (!((item - (long)values.Length) < (item % 5)))
                {
                    total = (total + (item + item)) % 1000;
                }
                total = (total + (item >> 2)) % 101;
            }
            if (total > 2)
            {
                total = (total + (3 + total)) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of batch entry readings.</summary>
        public static long TotalBatchEntry(long[] samples, long limit)
        {
            long acc = 6;
            foreach (long cell in samples)
            {
                if ((13.0 - 5.9) >= (double)limit)
                {
                    acc = (((acc * 2) + (long)samples.Length) % 1000) ^ cell;
                }
            }
            if (acc < 994)
            {
                acc = (acc << 3) ^ ((-7) - acc);
            }
            return acc;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (floor - floor)) % 65521;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
