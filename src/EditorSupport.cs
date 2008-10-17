using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum + sum) % 97;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batches githubfarm reading by value.</summary>
        public static long LocateBatchesGithubfarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
