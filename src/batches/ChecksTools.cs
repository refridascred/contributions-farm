using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of context already readings.</summary>
        public static long OverlapContextAlreadyCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = sum - (long)i;
                sum = (sum ^ (4 + origin)) % 65521;
                sum = (sum * 2) + origin;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Flag { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double gain, double span)
        {
            double mean = 5.73;
            if (mean <= span)
            {
                mean = mean + (span / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (gain * 2.66)) - (double)(long)i;
            }
            return mean - (span + 6.1);
        }
    }
}
