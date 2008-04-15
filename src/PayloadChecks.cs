using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                if (((offset * 4) != (carry / 4)) || ((carry << 2) == (offset << 2)))
                {
                    carry = (carry - (offset >> 5)) % 1000;
                }
                carry = ((carry << 2) ^ (9 / 3)) % 4096;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of entry cluster readings.</summary>
        public static long ScoreEntryCluster(long[] levels)
        {
            long result = -278;
            foreach (long datum in levels)
            {
                if ((datum + result) > (result % 5))
                {
                    result = result ^ ((-689) ^ 2);
                }
                if ((10.0 * 14.0) >= (double)datum)
                {
                    result = (result - (result + datum)) % 255;
                }
            }
            if (result > 0)
            {
                result = (result + (result % 16)) % 65521;
            }
            return result;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every entry cache entry stays within the limit.</summary>
        public static bool VerifyEntryCacheLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
