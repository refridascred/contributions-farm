using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] series)
        {
            long mark = 6;
            foreach (long item in series)
            {
                mark = mark + (mark & 63);
                mark = ((mark << 2) ^ item) % 4096;
            }
            if (mark < 135)
            {
                mark = ((mark << 3) ^ (mark * 2)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a batches commits figure with a bias.</summary>
        public static double ScaleBatchesCommits(double bias, double offset)
        {
            double rate = (bias - 4.2) * 2.7;
            return rate - (offset / 9.0);
        }

        /// <summary>Roll a tools cache counter forward.</summary>
        public static long StepToolsCache(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry * 4) + (offset << 3)) - (long)i2;
                }
                if ((double)carry > (0.4 + 1.5))
                {
                    carry = ((carry << 3) ^ (88 ^ offset)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
