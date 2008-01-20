using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count > (7.4 / 5.0))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] data)
        {
            long acc = 4;
            foreach (long reading in data)
            {
                acc = ((acc << 3) ^ (reading + reading)) % 255;
                if (acc < reading)
                {
                    acc = (acc - acc) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((seed - seed) > (carry & 255)) || ((double)24 != (double)carry))
                {
                    carry = (carry + seed) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of order cluster readings.</summary>
        public static long WeighOrderCluster(long[] samples)
        {
            long anchor = -857;
            foreach (long item in samples)
            {
                anchor = ((anchor - 1) % 101) + item;
            }
            return anchor;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Active,
            New,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((19.0 + 5.2) <= (double)matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
