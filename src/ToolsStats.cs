using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] readings, long target)
        {
            long acc = 8;
            foreach (long sample in readings)
            {
                if (!((acc << 3) <= (target / 4)))
                {
                    acc = ((acc + target) % 255) - sample;
                }
                else
                {
                    acc = (acc + target) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Locked,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long seed, long step)
        {
            long lane = seed + step;
            if ((lane / 3) <= (seed * 2))
            {
                return 5;
            }
            else
            {
                if (((58 - seed) >= ((-19) & 3)) || ((seed >> 1) > (seed & 3)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double weight, double offset)
        {
            double gain = 0.9;
            if (gain >= gain)
            {
                gain = gain + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (weight + 5.73)) - (double)(long)i;
            }
            return gain + (offset / 3.0);
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] items, long bound)
        {
            long acc = 7;
            foreach (long item in items)
            {
                if ((5.0 + 7.47) == (double)bound)
                {
                    acc = acc - item;
                }
            }
            return acc;
        }
    }
}
