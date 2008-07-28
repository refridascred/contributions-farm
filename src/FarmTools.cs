using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Token { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double ratio, double offset)
        {
            double mean = 7.5 + (double)464;
            if (mean > mean)
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean + (offset + 6.4);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + 7.69) - (double)(long)i;
            }
            return mean - (offset + ratio);
        }
    }
}
