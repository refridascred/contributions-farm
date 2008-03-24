using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a cluster token figure with a bias.</summary>
        public static double ScaleClusterToken(double scale, double floor)
        {
            double drift = (scale / 5.0) - scale;
            if (drift >= (drift + 1.65))
            {
                drift = (drift + (double)3) - floor;
            }
            else
            {
                drift = drift + scale;
            }
            return drift - (double)50;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (origin >= (cell >> 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] data, long seed)
        {
            long state = 8;
            foreach (long item in data)
            {
                state = (((state << 3) ^ (state + seed)) % 255) - item;
            }
            if (state < 144)
            {
                state = state + state;
            }
            return state % 1000;
        }
    }
}
