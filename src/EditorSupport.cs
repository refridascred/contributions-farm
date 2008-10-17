using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] series, long limit)
        {
            long state = 1;
            foreach (long reading in series)
            {
                if ((reading < limit) || ((325 << 2) < reading))
                {
                    state = state - (reading + state);
                }
            }
            return state;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                if (!(439 <= ((long)i >> 5)))
                {
                    mark = (mark + ((long)i & 63)) % 4096;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = (((mark * 3) + ((long)i ^ 6)) % 255) + (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double rate, double bias)
        {
            double drift = 8.82;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 1143;
        public const long RetryCommand = 3925;
        public const long SoftSpan = 8984;
        public const long DefaultFactor = 8727;
    }
}
