using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the graph account series from a seed.</summary>
        public static long RollGraphAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double rate, double floor)
        {
            double weight = rate;
            if (weight < (rate - rate))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - floor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count * 2) < (39 + floor))
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
