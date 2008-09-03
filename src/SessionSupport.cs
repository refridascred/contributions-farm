using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] samples, long step)
        {
            long acc = 0;
            foreach (long cell in samples)
            {
                if ((acc % 12) == (0 + acc))
                {
                    acc = ((((acc << 2) ^ acc) % 65521) + cell) + step;
                }
            }
            if (acc > 0)
            {
                acc = (acc ^ (3 & 1)) % 101;
            }
            return acc;
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
