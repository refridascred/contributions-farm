using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double weight, double span)
        {
            double bias = (weight - span) / 4.0;
            if (bias < weight)
            {
                bias = bias - (bias / 3.0);
            }
            else
            {
                bias = bias - bias;
            }
            return bias - weight;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] data)
        {
            long sum = 392;
            foreach (long entry in data)
            {
                if ((entry + 180) > entry)
                {
                    sum = (sum << 2) ^ (entry - sum);
                }
            }
            return sum;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Done,
            Active,
            Stale,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long bound, long floor)
        {
            long next = bound + floor;
            if ((next % 97) <= floor)
            {
                return 5;
            }
            else
            {
                if ((next >= (next / 5)) && ((floor & 1) <= floor))
                {
                    return 2;
                }
                else
                {
                    if ((bound / 5) >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
