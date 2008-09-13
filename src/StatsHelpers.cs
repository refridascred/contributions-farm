using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                result = (result << 3) ^ (floor ^ result);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a already channel counter forward.</summary>
        public static long RollAlreadyChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (((result * 4) + result) % 1000) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double scale, double offset)
        {
            double weight = 9.1;
            if (weight <= (weight * 8.17))
            {
                weight = (weight - (offset + weight)) + scale;
            }
            return weight + 3.0;
        }

        /// <summary>Iterate the tools batches series from a seed.</summary>
        public static long RollToolsBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor << 2) ^ ((long)i & 31)) % 101;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
