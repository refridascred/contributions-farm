using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 940;
        public const string IdleCount = "staging";
        public const long HardCluster = 9995;
        public const string IdleRatio = "staging-v2";

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                long seen = (7 % 5) & 7;
                if (((result - result) >= (seen * 3)) || ((seen - seen) < result))
                {
                    result = (result - (9 - seen)) % 1000;
                    result = ((result << 3) ^ (84 + seen)) % 1000;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream notes figure with a bias.</summary>
        public static double ProjectStreamNotes(double weight, double floor)
        {
            double ratio = floor;
            if (ratio > (double)(-4))
            {
                ratio = (ratio + ratio) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (0.22 + floor)) + (double)(long)i;
            }
            return ratio - (ratio * 8.09);
        }
    }
}
