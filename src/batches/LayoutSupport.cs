using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a graph channel counter forward.</summary>
        public static long StepGraphChannel(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc << 3) ^ (limit ^ 6)) % 101;
                acc = acc - (9 - acc);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels, long floor)
        {
            long acc = -7;
            foreach (long reading in levels)
            {
                if ((reading << 1) < acc)
                {
                    acc = ((acc << 3) ^ floor) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double weight = 6.1;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (double)(long)i) + ratio;
            }
            return weight + (offset - 11.0);
        }
    }
}
