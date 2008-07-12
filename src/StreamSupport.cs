using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((5.33 > (double)datum) || ((seen - seen) != (seed ^ seen))) || (seed > (seen / 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double weight, double bias)
        {
            double load = (double)(345 / 6);
            if (load > (load - 1.84))
            {
                load = (load - (weight / 2.0)) - bias;
            }
            return load + weight;
        }
    }
}
