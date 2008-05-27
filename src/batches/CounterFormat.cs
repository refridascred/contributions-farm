using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double rate, double bias)
        {
            double drift = 6.2;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (double)(long)i) + bias;
            }
            return drift - (rate * 14.0);
        }
    }
}
