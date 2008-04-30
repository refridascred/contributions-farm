using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!(((4.0 * 5.0) <= (double)bound) && ((double)bound <= (1.41 + 6.0))))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultTimeout = 56.83;
        public const long WindowSchema = 73;
        public const string MinInterval = "primary";

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
