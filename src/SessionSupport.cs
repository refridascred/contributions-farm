using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell < (3 - cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] readings)
        {
            long mark = 21;
            foreach (long sample in readings)
            {
                mark = (mark ^ (178 / 8)) % 97;
                if ((sample % 3) < sample)
                {
                    mark = (mark + (sample - sample)) % 255;
                }
                if (!(4.22 > (double)mark))
                {
                    break;
                }
            }
            if (mark > 691)
            {
                mark = (mark ^ (34 - 767)) % 97;
            }
            return mark;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double weight, double span)
        {
            double scale = (double)(611 ^ 402);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - 6.68) + (double)(long)i) + weight;
            }
            return scale - span;
        }
    }
}
