using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of support batch readings.</summary>
        public static long TotalSupportBatch(long[] readings, long bound)
        {
            long carry = 5;
            foreach (long sample in readings)
            {
                if ((double)(long)readings.Length != (2.45 * 0.65))
                {
                    carry = ((((carry * 3) + 0) % 1000) + sample) - bound;
                }
            }
            return carry % 1000;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double rate, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (bias - rate)) + (double)(long)i;
            }
            return drift - (drift * 3.7);
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long origin)
        {
            if ((origin - origin) >= origin)
            {
                return 4;
            }
            else
            {
                if ((origin * 4) == (origin ^ target))
                {
                    return 7;
                }
                else
                {
                    if (!((4.0 + 14.0) > (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((target + target) == (origin * 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of schema format readings.</summary>
        public static long CombineSchemaFormat(long[] values, long offset)
        {
            long total = -9;
            foreach (long cell in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((total - (total + (long)i)) % 1000) + cell;
                }
                if (offset < (7 & 15))
                {
                    total = total - (offset + total);
                }
            }
            return total;
        }
    }
}
