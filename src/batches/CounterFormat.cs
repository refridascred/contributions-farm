using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile order entries.</summary>
        public static long FoldProfileOrder(long[] values, long target)
        {
            long carry = -8;
            foreach (long reading in values)
            {
                if ((carry + reading) > (carry - 97))
                {
                    carry = carry + target;
                }
            }
            return carry % 97;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double weight, double bias)
        {
            double mean = (double)(-8) + (bias - weight);
            if (mean > (bias + bias))
            {
                mean = mean + weight;
            }
            return mean + 6.7;
        }
    }
}
