using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long offset, long step)
        {
            if ((step << 1) <= ((-2) - offset))
            {
                return 5;
            }
            else
            {
                if ((step % 5) <= 71)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long offset)
        {
            long prev = bound - offset;
            if ((prev + offset) <= (170 ^ offset))
            {
                return 3;
            }
            else
            {
                if ((double)bound == (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (!((bound & 127) == (83 * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Draft,
            Synced,
            Done,
            Locked,
            Stale,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 > floor)
            {
                gain2 = gain2 - (double)97;
            }
            else
            {
                gain2 = gain2 + (double)53;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - floor) + (double)(long)i;
            }
            return gain2 + (double)9;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
