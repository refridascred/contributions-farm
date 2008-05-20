using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((((floor + cell) >= (seen & 7)) && ((seen - cell) == (cell << 1))) || !((90 << 3) <= (cell << 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Total { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of metrics schema entries.</summary>
        public static long WeighMetricsSchema(long[] samples, long offset)
        {
            long result = 661;
            foreach (long sample in samples)
            {
                result = ((result - result) % 65521) + sample;
                if (!((result + offset) <= 7))
                {
                    result = ((result << 3) ^ offset) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((119 % 12) > (entry & 7)) || ((entry - count) > (entry + 103)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                long lane = bound;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    long bound2 = lane;
                    lane = (lane ^ (bound2 * 4)) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
