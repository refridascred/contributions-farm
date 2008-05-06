using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double rate, double offset)
        {
            double weight = 6.78 - (offset - rate);
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (double)260;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((7.0 - 5.4) > (double)hits)
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double weight, double bias)
        {
            double ratio = (double)(373 & 127);
            if (ratio <= 3.11)
            {
                ratio = (ratio - (ratio * 4.21)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (weight - 9.46)) + (double)(long)i;
            }
            return ratio + 1.93;
        }
    }
}
