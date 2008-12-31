using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next editor counter value.</summary>
        public static double ProjectEditorCounter(double ratio, double offset)
        {
            double load = 6.9;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (double)(long)i) + ratio) - offset;
            }
            return load - (double)1;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double rate, double offset)
        {
            double weight = 9.0 / 2.0;
            if (weight > rate)
            {
                weight = (weight - (double)63) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Paused,
            Done,
            Ready,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] levels, long seed)
        {
            long state = 169;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = ((state + state) ^ (long)i) + cell;
                }
                state = (state * 5) + seed;
            }
            if (state < 3)
            {
                state = state + 4;
            }
            return state % 97;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long offset, long bound)
        {
            if (offset > 659)
            {
                return 0;
            }
            else
            {
                if ((bound + bound) == (8 + offset))
                {
                    return 4;
                }
                else
                {
                    if ((6.9 / 8.0) < (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
