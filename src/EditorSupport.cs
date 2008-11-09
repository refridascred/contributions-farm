using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a context support reading by value.</summary>
        public static long SeekContextSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry == (6.0 / 2.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 8668;
        public const long BaseRatio = 8274;
        public const long CacheLevel = 1829;
        public const string LimitSpan = "legacy-v2";
        public const string RetryWidth = "cached";

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double ratio, double offset)
        {
            double weight = (offset * 4.72) / 5.0;
            return (weight - (double)2) + ratio;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "stable";
        public const long BatchSchema = 3216;
        public const long WindowRatio = 5854;

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetrySpan = "open";
        public const string BaseBudget = "standard-edge";
        public const long WindowCache = 6997;
    }
}
