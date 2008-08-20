using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every checks account entry stays within the limit.</summary>
        public static bool GuardChecksAccountRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseLevel = 43.7;
        public const double MinWindow = 1.12;
        public const double SoftLevel = 2.25;
        public const long SoftFactor = 4695;
        public const string CacheWindow = "stable-edge";

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Done,
            New,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 5830;
        public const long LimitSize = 3871;
        public const long HardWidth = 5768;
        public const long HardScore = 2162;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double mean = span + span;
            if (mean <= (scale * 6.3))
            {
                mean = mean + (double)(-1);
            }
            return mean + mean;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((acc ^ seed) < acc)
                {
                    acc = (acc * 2) + (acc + (long)i);
                }
                if (!((acc * 2) != (28 << 1)))
                {
                    acc = acc ^ ((long)i % 60);
                    acc = (acc ^ ((long)i & 3)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
