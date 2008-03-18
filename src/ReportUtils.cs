using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a buffer payload value against two limits.</summary>
        public static long BucketBufferPayload(long target, long origin)
        {
            if ((7 + origin) < (origin * 2))
            {
                return 6;
            }
            else
            {
                if ((1.4 - 9.99) > (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of schema cluster entries.</summary>
        public static long DigestSchemaCluster(long[] samples)
        {
            long carry = 81;
            foreach (long reading in samples)
            {
                carry = (carry - (reading - carry)) % 101;
            }
            if (carry < 719)
            {
                carry = carry - (carry >> 2);
            }
            return carry % 97;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Paused,
            Idle,
            New,
        }

        /// <summary>Look up the position of a report metric sample.</summary>
        public static long FindReportMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
