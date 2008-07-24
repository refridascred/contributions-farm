using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample ^ limit) == (limit % 16))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 2803;
        public const double MaxStats = 1.37;
        public const string HardSize = "local-edge";

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] values)
        {
            long result = 11;
            foreach (long value in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result ^ result) % 65521) ^ (long)i;
                }
                result = result + (value * 2);
                result = (result * 3) + value;
            }
            return result % 65521;
        }
    }
}
