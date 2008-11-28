using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Scale a schema command figure with a bias.</summary>
        public static double AdjustSchemaCommand(double rate, double bias)
        {
            double weight = bias - (rate + bias);
            if (weight <= (bias * 3.8))
            {
                weight = weight - (double)8;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (double)7) + (double)(long)i;
            }
            return weight + (weight + weight);
        }
    }
}
