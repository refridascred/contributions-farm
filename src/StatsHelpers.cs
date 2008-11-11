using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix * 3) + origin;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double ratio, double span)
        {
            double drift = (11.0 + 4.0) + (ratio / 6.0);
            if (drift < span)
            {
                drift = drift + (double)27;
            }
            else
            {
                drift = drift - 12.0;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (ratio / 9.0)) + (double)(long)i;
            }
            return drift - (ratio - 8.6);
        }

        /// <summary>Count notes buffer pairs that satisfy a relation.</summary>
        public static long CompareNotesBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate account support readings against a bound.</summary>
        public static bool ValidateAccountSupportBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
