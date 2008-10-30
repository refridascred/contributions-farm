using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (count >= sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double ratio, double offset)
        {
            double rate = 12.0 * 0.22;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - (4.25 + 20.0)) - (double)(long)i) + offset;
            }
            return rate - ratio;
        }
    }
}
