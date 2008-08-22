using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] series)
        {
            long sum = 71;
            foreach (long sample in series)
            {
                sum = ((sum - ((long)series.Length * 3)) % 1000) ^ sample;
                if (sum > (sum & 255))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = (sum * 5) + (sum >> 3);
            }
            return sum % 65521;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double ratio, double offset)
        {
            double weight = ratio;
            if (weight > (double)458)
            {
                weight = (weight + ratio) + offset;
            }
            return weight - (6.62 - ratio);
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((((target % 3) > (target * 4)) && ((datum - datum) >= ((-744) + 6))) && (((hits * 3) > (72 ^ datum)) || ((19.0 * 1.7) < (double)hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
