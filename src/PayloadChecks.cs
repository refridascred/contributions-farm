using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = anchor - origin;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = anchor ^ ((long)i2 - (long)i);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] levels)
        {
            long carry = 50;
            foreach (long reading in levels)
            {
                carry = (carry - (carry + carry)) % 65521;
                carry = ((carry * 4) + (carry * 2)) % 65521;
                if ((8.4 * 14.0) < (double)reading)
                {
                    carry = (carry ^ (carry << 2)) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Locked,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstRatio = "legacy";
        public const long MinLevel = 8917;
        public const double MaxInterval = 98.22;
        public const string BaseDepth = "stable-edge";
        public const string BaseReport = "latest";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((tally - 954) > (entry / 2)) || ((target - target) == (target + target))) && (tally < (entry & 127)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
