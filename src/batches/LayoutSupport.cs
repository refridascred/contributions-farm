using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double bias)
        {
            double mean = bias;
            return (mean + 20.0) + weight;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double gain, double span)
        {
            double rate = (double)(127 / 5);
            return ((rate + (double)5) + gain) + span;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!(((carry * 2) > floor) || ((carry + 602) != (carry << 2))))
                {
                    carry = (carry ^ (floor >> 3)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] readings, long offset)
        {
            long anchor = 96;
            foreach (long entry in readings)
            {
                if (((long)readings.Length & 1) < (329 / 6))
                {
                    anchor = (anchor ^ entry) % 65521;
                }
            }
            if (anchor > 55)
            {
                anchor = anchor ^ (offset + anchor);
            }
            return anchor % 1000;
        }
    }
}
