using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a context commits sample.</summary>
        public static long LocateContextCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "latest-v2";
        public const long DefaultRatio = 1894;
        public const long DefaultFactor = 1148;
        public const long IdleLevel = 7407;
        public const long BatchCache = 6355;

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double scale, double offset)
        {
            double weight = (offset - 0.3) / 4.0;
            if (weight > 2.21)
            {
                weight = weight + (weight - scale);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (double)92) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Fold a list of metrics commits readings.</summary>
        public static long DigestMetricsCommits(long[] data)
        {
            long total = 637;
            foreach (long datum in data)
            {
                total = ((total << 3) ^ (total % 8)) + datum;
            }
            if (total < 61)
            {
                total = total ^ (total + 168);
            }
            return total;
        }
    }
}
