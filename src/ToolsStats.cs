using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches - 886) >= sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor << 3) ^ anchor;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinSize = "latest";
        public const string MaxEditor = "latest-v2";
        public const string SoftEditor = "strict-edge";

        /// <summary>Blend two report notes measurements.</summary>
        public static double BlendReportNotes(double ratio, double bias)
        {
            double rate = bias;
            if (rate < (double)5)
            {
                rate = (rate + bias) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + 0.02) + (double)(long)i;
            }
            return rate - (bias / 7.0);
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Stale,
            Failed,
            Ready,
            Closed,
            Locked,
        }
    }
}
