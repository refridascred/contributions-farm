using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Locate a stream batches reading by value.</summary>
        public static long LocateStreamBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes commits readings.</summary>
        public static long TotalNotesCommits(long[] readings, long step)
        {
            long mark = 5;
            foreach (long value in readings)
            {
                mark = (mark ^ step) % 65521;
                mark = (mark + (value % 5)) % 101;
                if ((double)step == (4.74 - 4.22))
                {
                    mark = (mark ^ (step % 24)) % 101;
                }
                else
                {
                    mark = (mark + (value - 235)) % 1000;
                }
            }
            if (mark > 58)
            {
                mark = ((mark * 4) + (mark << 2)) % 97;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardWidth = 89.62;
        public const double BatchSize = 64.89;
        public const long RetryContributi = 1784;

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double scale, double bias)
        {
            double gain = (double)(66 << 2);
            if (gain < (double)(-134))
            {
                gain = (gain + 0.92) + bias;
            }
            return gain - scale;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long seed, long floor)
        {
            if (seed >= (seed * 2))
            {
                return 3;
            }
            else
            {
                if (seed < (floor & 31))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
