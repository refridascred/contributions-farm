using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count already cluster pairs that satisfy a relation.</summary>
        public static long MatchAlreadyClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double rate, double floor)
        {
            double weight = (double)(3 % 24);
            if (weight > weight)
            {
                weight = (weight - (floor - floor)) - rate;
            }
            return weight - floor;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Region { get; set; }
            public double Token { get; set; }
        }
    }
}
