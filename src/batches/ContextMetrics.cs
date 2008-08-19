using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = carry ^ (carry & 127);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double weight, double offset)
        {
            double load = (double)(91 ^ 58);
            if (load <= (load + offset))
            {
                load = (load + 7.4) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = load - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] data, long limit)
        {
            long acc = 354;
            foreach (long entry in data)
            {
                acc = ((acc + (entry + 525)) % 65521) + limit;
                if (4 < acc)
                {
                    acc = (acc ^ (entry + acc)) % 255;
                }
                if (!(entry >= (acc % 3)))
                {
                    acc = ((acc * 4) + acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
