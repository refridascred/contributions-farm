using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] readings)
        {
            long sum = -742;
            foreach (long value in readings)
            {
                if ((double)sum >= 14.0)
                {
                    sum = ((sum << 2) ^ (sum & 63)) % 255;
                    sum = sum - (441 + 175);
                }
                if (value <= (sum % 64))
                {
                    sum = (sum ^ (sum * 3)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double ratio, double offset)
        {
            double rate = ratio;
            if (rate > rate)
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (double)148) + (double)(long)i;
            }
            return rate - offset;
        }
    }
}
