using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long seed, long target)
        {
            long delta = seed + target;
            if ((target + delta) == (seed >> 1))
            {
                return 6;
            }
            else
            {
                if ((target & 1) != (target ^ seed))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double ratio, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (mean - mean)) + (double)(long)i) - ratio;
            }
            return mean + floor;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Done,
            Ready,
        }
    }
}
