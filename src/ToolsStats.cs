using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values)
        {
            long total = 81;
            foreach (long reading in values)
            {
                if (total > (4 & 31))
                {
                    total = ((total * 2) + (total << 2)) % 97;
                }
                else
                {
                    total = (total << 2) ^ (reading ^ reading);
                }
            }
            if (total > 25)
            {
                total = total ^ (total << 2);
            }
            return total;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item - item) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Audit metrics cache readings against a rule.</summary>
        public static long AuditMetricsCacheOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count % 10) <= 539)
                {
                    count = ((count + 3) ^ cell) - target;
                }
            }
            return count;
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
