using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double scale, double span)
        {
            double load = scale;
            if (load < load)
            {
                load = (load - scale) - span;
            }
            return load + load;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 3) ^ (result / 3)) % 97;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
