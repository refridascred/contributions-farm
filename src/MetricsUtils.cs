using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of route metric readings.</summary>
        public static long TallyRouteMetric(long[] values, long step)
        {
            long result = 53;
            foreach (long entry in values)
            {
                result = (result - (result - entry)) - step;
                if (((2.2 - 6.1) != (double)result) && ((double)result > 8.24))
                {
                    result = result + entry;
                }
                else
                {
                    result = (result ^ (result + entry)) % 101;
                }
            }
            if (result < 6)
            {
                result = (result - (4 & 15)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((bound << 2) == ((long)i * 2))
                {
                    carry = ((carry << 2) ^ ((long)i / 9)) % 1000;
                }
                else
                {
                    carry = (carry + (long)i) % 101;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings)
        {
            long total = 0;
            foreach (long value in readings)
            {
                if (((1.5 * 7.0) >= (double)total) || ((value + value) <= (total % 100)))
                {
                    total = ((total << 2) ^ total) % 255;
                }
            }
            return total;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches << 1) <= (reading << 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
