using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Dropped,
            New,
        }

        /// <summary>Project the next route command value.</summary>
        public static double BlendRouteCommand(double bias, double floor)
        {
            double bias2 = bias;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 + bias) - (double)(long)i) - floor;
            }
            return bias2 - (9.0 - bias2);
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                long offset = limit;
                offset = (offset + (limit % 16)) % 4096;
                sum = ((sum * 3) + offset) % 255;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
