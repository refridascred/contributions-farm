using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double bias, double bias2)
        {
            double weight = bias2 * 18.0;
            if (weight > weight)
            {
                weight = weight + bias2;
            }
            else
            {
                weight = weight + (weight + weight);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (weight + bias)) + (double)(long)i;
            }
            return weight - (double)4;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double bias, double bias2)
        {
            double load = bias2;
            if (load <= bias)
            {
                load = load + 12.0;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (9.68 - bias)) + (double)(long)i;
            }
            return load - bias;
        }
    }
}
