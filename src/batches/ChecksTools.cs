using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double bias, double span)
        {
            double gain = bias;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (2.2 + gain)) + (double)(long)i) + span;
            }
            return gain + gain;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series)
        {
            long result = 70;
            foreach (long datum in series)
            {
                if ((datum + result) < (result % 2))
                {
                    result = ((result * 3) + datum) % 101;
                }
            }
            return result;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long origin, long seed)
        {
            if ((3.12 + 3.0) <= (double)origin)
            {
                return 2;
            }
            else
            {
                if ((double)origin != (6.7 / 2.0))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
