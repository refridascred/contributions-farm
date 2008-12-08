using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Region { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit report batches readings against a rule.</summary>
        public static long MeasureReportBatchesMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((double)count > (double)floor))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc << 2) ^ (acc - acc)) % 101) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
