using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (16 * 5)) % 97;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command farm value.</summary>
        public static double ScaleCommandFarm(double scale, double bias)
        {
            double bias2 = scale - (scale / 2.0);
            if (bias2 < (double)127)
            {
                bias2 = bias2 + 5.81;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
