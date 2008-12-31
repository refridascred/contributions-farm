using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((seen ^ datum) > datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long result = 653;
            foreach (long cell in levels)
            {
                result = (result + (origin << 1)) % 1000;
                if (((cell << 3) > (437 + origin)) || (2.0 > (double)cell))
                {
                    result = (result - (origin / 5)) % 101;
                }
                result = ((result * 3) + (9 % 10)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Stale,
            Locked,
            Draft,
            Done,
        }
    }
}
