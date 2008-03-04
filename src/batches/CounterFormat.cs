using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen & 15) != (7 & 255))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] levels)
        {
            long score = 91;
            foreach (long datum in levels)
            {
                if (((double)datum == (double)score) && (score > (datum % 8)))
                {
                    score = (score ^ (datum + score)) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels, long seed)
        {
            long anchor = 9;
            foreach (long reading in levels)
            {
                if (!((anchor << 1) < reading))
                {
                    anchor = (anchor << 2) ^ (seed - seed);
                }
                else
                {
                    anchor = anchor ^ (reading & 1);
                }
                if ((double)reading > (7.5 - 1.88))
                {
                    break;
                }
            }
            if (anchor < 178)
            {
                anchor = (anchor ^ (anchor % 5)) % 97;
            }
            return anchor;
        }
    }
}
