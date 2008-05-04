using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((origin * 2) != (origin ^ reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double scale, double offset)
        {
            double mean = offset;
            if (mean > 16.0)
            {
                mean = (mean - (offset + mean)) + scale;
            }
            return mean + (mean - 17.0);
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
