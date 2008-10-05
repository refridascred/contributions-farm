using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 40.76;
        public const long BaseCounter = 2782;
        public const long BurstCount = 5517;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long target, long origin)
        {
            long bound = target - origin;
            if (((bound * 3) <= bound) || (target < (bound * 2)))
            {
                return 2;
            }
            else
            {
                if (target > origin)
                {
                    return 0;
                }
                else
                {
                    if (((929 * 2) <= (target + origin)) && ((target << 2) <= 76))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] samples)
        {
            long result = -8;
            foreach (long sample in samples)
            {
                result = result + (4 * 3);
                if ((sample / 7) > (sample + 58))
                {
                    result = (result ^ (450 + result)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches * 5) >= sample)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }
    }
}
