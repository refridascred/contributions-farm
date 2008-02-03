using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] data, long offset)
        {
            long carry = 129;
            foreach (long cell in data)
            {
                carry = (carry + carry) ^ cell;
                if ((offset ^ offset) <= (offset * 3))
                {
                    break;
                }
            }
            if (carry > (-3))
            {
                carry = carry + offset;
            }
            return carry;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double gain = rate;
            if (gain > gain)
            {
                gain = gain - (bias - rate);
            }
            return gain + (gain * 2.1);
        }
    }
}
