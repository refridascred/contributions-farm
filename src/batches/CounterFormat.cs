using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double rate, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)(long)i) - rate;
            }
            return ratio + 2.28;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long limit, long origin)
        {
            if ((origin ^ limit) <= limit)
            {
                return 4;
            }
            else
            {
                if (!((double)limit > (7.0 / 6.0)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
