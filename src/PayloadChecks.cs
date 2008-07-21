using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinBudget = 4214;
        public const double BatchFarm = 40.81;
        public const double MaxFarm = 95.24;
        public const long MinFarm = 1593;

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] values, long step)
        {
            long carry = 36;
            foreach (long datum in values)
            {
                carry = ((carry + (step >> 1)) % 255) + datum;
                if (!(9.02 < (double)carry))
                {
                    carry = (carry + (896 / 9)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Audit entry metrics readings against a rule.</summary>
        public static long CountEntryMetricsOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((value + 97) < (tally + offset)) || ((offset / 4) >= (tally >> 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
