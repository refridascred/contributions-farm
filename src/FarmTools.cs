using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double bias, double bias2)
        {
            double weight = (bias + bias2) / 3.0;
            if (weight < (bias / 2.0))
            {
                weight = weight + (double)(-925);
            }
            else
            {
                weight = weight - weight;
            }
            return weight + (double)8;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count + count) > (count - sample))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
