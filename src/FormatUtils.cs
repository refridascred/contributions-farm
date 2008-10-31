using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double bias, double offset)
        {
            double load = (double)63 + (2.79 / 2.0);
            if (load < load)
            {
                load = load + (bias * 5.2);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 4.0) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series, long floor)
        {
            long sum = 9;
            foreach (long value in series)
            {
                sum = ((sum * 3) + (value + floor)) % 65521;
                if ((4 - sum) < sum)
                {
                    sum = sum - (floor << 1);
                }
                if ((923 / 4) < sum)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum + (origin + sum)) % 1000;
                sum = ((sum * 4) + (long)i) % 4096;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every entry support entry stays within the limit.</summary>
        public static bool GuardEntrySupportBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (step > (7 >> 5))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
