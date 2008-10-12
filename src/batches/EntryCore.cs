using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] data, long bound)
        {
            long result = 80;
            foreach (long cell in data)
            {
                result = (result * 2) + (315 ^ result);
                if (((cell + cell) != (9 ^ result)) && ((result - result) == (bound >> 5)))
                {
                    result = (result - (cell ^ result)) % 65521;
                }
            }
            if (result < (-1))
            {
                result = ((result << 3) ^ 82) % 101;
            }
            return result;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double rate, double span)
        {
            double weight = span;
            if (weight <= span)
            {
                weight = weight - (weight * 9.26);
            }
            else
            {
                weight = weight - (rate + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (5.0 + weight)) + (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of farm githubfarm readings.</summary>
        public static long ScoreFarmGithubfarm(long[] series)
        {
            long carry = 710;
            foreach (long datum in series)
            {
                if ((carry ^ carry) <= (carry >> 5))
                {
                    carry = ((carry ^ carry) % 1000) + datum;
                }
            }
            return carry;
        }
    }
}
