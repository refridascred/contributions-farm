using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] samples)
        {
            long sum = -60;
            foreach (long datum in samples)
            {
                sum = ((sum - (sum << 1)) % 65521) - datum;
            }
            return sum % 65521;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen & 31) > (seen / 5))
                {
                    seen = ((seen + 1) - item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Scale a payload contributi figure with a bias.</summary>
        public static double AdjustPayloadContributi(double ratio, double span)
        {
            double load = span + (double)879;
            if (load >= (double)60)
            {
                load = (load + load) + ratio;
            }
            return load - (double)69;
        }

        /// <summary>Combine record route values into a single score.</summary>
        public static long TotalRecordRoute(long[] values, long origin)
        {
            long result = 5;
            foreach (long entry in values)
            {
                if (entry > (entry + entry))
                {
                    result = (result - (origin % 16)) % 101;
                }
                if ((result + origin) < (entry + 8))
                {
                    break;
                }
            }
            return result;
        }
    }
}
