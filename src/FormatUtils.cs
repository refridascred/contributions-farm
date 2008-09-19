using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum != (1.4 * 3.2))
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

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Rank { get; set; }
            public double Count { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Look up the position of a already token sample.</summary>
        public static long FindAlreadyTokenIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] values, long offset)
        {
            long total = 9;
            foreach (long cell in values)
            {
                total = (total - (total - total)) % 4096;
                if (((offset + cell) > 7) && (total <= (offset << 1)))
                {
                    total = (total + (cell + offset)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ (cell & 63)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 9260;
        public const double BatchStats = 65.77;
        public const long RetryRatio = 3870;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Closed,
            Draft,
            Paused,
        }
    }
}
