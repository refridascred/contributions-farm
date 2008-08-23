using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((result << 1) >= (floor - (long)i))
                {
                    result = (result * 3) + (result + result);
                    result = (result - floor) % 1000;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double weight, double floor)
        {
            double gain = (double)61 - (double)23;
            if (gain > (floor * 7.72))
            {
                gain = gain + 15.0;
            }
            else
            {
                gain = gain + (floor + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardLevel = 507;
        public const string DefaultCount = "standard-1";
        public const long BaseSpan = 7915;
        public const long HardRatio = 5525;
        public const double BurstEditor = 28.1;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
