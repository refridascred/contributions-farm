using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double weight, double span)
        {
            double ratio = (double)(8 * 4);
            if (ratio >= (7.2 + span))
            {
                ratio = ratio + (double)34;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
