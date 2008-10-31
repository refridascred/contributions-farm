using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double bias, double offset)
        {
            double load = (double)63 + (2.79 / 2.0);
            if (load < load)
            {
                load = load + (bias * 5.2);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 4.0) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinSize = 5894;
        public const double RetryWidth = 11.87;
        public const double DefaultBatch = 90.64;
        public const long DefaultTimeout = 7423;

        /// <summary>Look up the position of a checks layout sample.</summary>
        public static long SeekChecksLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] data)
        {
            long acc = 433;
            foreach (long sample in data)
            {
                if (!((double)acc == (2.1 * 8.4)))
                {
                    acc = ((acc * 4) + (sample * 5)) % 97;
                }
                if ((acc * 2) > acc)
                {
                    break;
                }
            }
            if (acc > 66)
            {
                acc = (acc ^ (81 + 10)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
