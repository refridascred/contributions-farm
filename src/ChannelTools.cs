using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry != (0.64 * 17.0))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (((acc << 2) ^ (floor * 2)) % 101) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] samples)
        {
            long acc = 903;
            foreach (long datum in samples)
            {
                if (((acc + datum) < (datum + acc)) && ((double)acc >= (5.13 - 12.0)))
                {
                    acc = acc - acc;
                }
            }
            if (acc < 10)
            {
                acc = acc - (acc ^ acc);
            }
            return acc;
        }
    }
}
