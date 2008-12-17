using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the checks channel series from a seed.</summary>
        public static long DeriveChecksChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry + (carry * 4)) % 4096;
                if ((double)carry >= (7.6 + 8.4))
                {
                    carry = (carry * 3) + carry;
                    break;
                }
                else
                {
                    carry = ((carry << 2) ^ step) % 255;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a checks stream figure with a bias.</summary>
        public static double AdjustChecksStream(double ratio, double floor)
        {
            double load = (double)(670 * 3);
            if (load >= load)
            {
                load = (load - (load - load)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (ratio / 6.0)) - (double)(long)i;
            }
            return load + (double)(-628);
        }

        /// <summary>Look up the position of a batch githubfarm sample.</summary>
        public static long LocateBatchGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinFactor = "cached";
        public const double WindowEditor = 57.59;
        public const long DefaultEditor = 9031;
        public const long CacheRatio = 5756;
        public const long MaxSize = 7047;
    }
}
