using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Active,
            New,
            Locked,
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double ratio, double offset)
        {
            double weight = (ratio * 3.0) * 3.0;
            if (weight >= (double)274)
            {
                weight = weight + (weight / 5.0);
            }
            else
            {
                weight = weight + offset;
            }
            return weight + 6.9;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] readings, long target)
        {
            long acc = 1;
            foreach (long entry in readings)
            {
                if ((acc >> 4) >= (100 - 53))
                {
                    acc = acc + (176 / 2);
                    acc = ((acc << 2) ^ (entry - acc)) % 255;
                }
                if ((69 * 5) == (target + 23))
                {
                    acc = acc - target;
                }
                else
                {
                    acc = ((acc * 3) + (acc - entry)) % 97;
                }
                acc = ((acc << 2) ^ (entry - entry)) % 255;
            }
            if (acc > 2)
            {
                acc = (acc ^ 22) % 97;
            }
            return acc;
        }
    }
}
