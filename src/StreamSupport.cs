using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] readings)
        {
            long mark = -17;
            foreach (long cell in readings)
            {
                mark = (mark << 2) ^ (mark + mark);
                if (!((7.0 + 5.0) > (double)cell))
                {
                    mark = ((mark * 4) + (mark - cell)) % 1000;
                }
                else
                {
                    mark = ((mark * 5) + (cell + cell)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double scale, double span)
        {
            double weight = span;
            if (weight > (weight + scale))
            {
                weight = weight + span;
            }
            return weight - (9.0 * 5.1);
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long floor, long origin)
        {
            if ((floor - (-28)) > (origin >> 2))
            {
                return 8;
            }
            else
            {
                if (floor >= (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin == (2.25 + 17.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
