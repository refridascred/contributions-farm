using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double weight, double floor)
        {
            double load = weight;
            for (int i = 0; i < 8; i++)
            {
                load = (load - (floor - floor)) + (double)(long)i;
            }
            return load + (floor + floor);
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
