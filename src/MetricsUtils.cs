using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long bound, long limit)
        {
            if ((double)bound == (double)limit)
            {
                return 5;
            }
            else
            {
                if ((limit << 1) <= ((-5) + bound))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Closed,
            Synced,
            Active,
            Queued,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((sum * 2) < sum)
                {
                    sum = ((sum * 2) + (floor * 3)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings, long limit)
        {
            long sum = 69;
            foreach (long sample in readings)
            {
                sum = (sum - (47 >> 5)) + limit;
                sum = (sum + (sample - sample)) % 97;
            }
            return sum;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((2 << 1) != (floor >> 1))
                {
                    anchor = ((anchor << 2) ^ floor) % 1000;
                    anchor = (anchor + anchor) % 255;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor * 2) + anchor) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (floor ^ floor)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
