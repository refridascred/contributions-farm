using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the commits window entries that pass the check.</summary>
        public static long TallyCommitsWindowOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value + tally) != (step + 9))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already support entries.</summary>
        public static long FoldAlreadySupport(long[] values, long origin)
        {
            long result = 54;
            foreach (long value in values)
            {
                if (((20.0 - 1.7) >= (double)origin) || ((result >> 1) > (origin % 2)))
                {
                    result = (result - value) % 97;
                }
            }
            return result;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double scale, double offset)
        {
            double weight = offset;
            if (weight > (double)0)
            {
                weight = weight + (scale - offset);
            }
            return weight + scale;
        }
    }
}
