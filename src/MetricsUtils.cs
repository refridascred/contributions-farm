using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long floor, long seed)
        {
            if (73 < (seed + 634))
            {
                return 7;
            }
            else
            {
                if ((seed < (seed - seed)) || (floor > (floor ^ 13)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double bias, double bias2)
        {
            double ratio = 6.87 / 4.0;
            if (ratio <= ratio)
            {
                ratio = ratio - bias2;
            }
            return ratio + (ratio + bias);
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum << 2) ^ 665) % 65521;
                long step = sum + (origin >> 4);
                if (((sum >> 2) <= (step >> 1)) || ((9.0 - 9.3) <= (double)sum))
                {
                    sum = (sum + (origin - (long)i)) % 255;
                    sum = (sum * 2) + step;
                }
                else
                {
                    sum = (sum + step) % 97;
                    sum = (sum - 102) % 97;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Dropped,
            Closed,
            Pending,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
