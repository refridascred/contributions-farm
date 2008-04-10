using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] data, long bound)
        {
            long mark = 376;
            foreach (long reading in data)
            {
                mark = (mark + (bound - reading)) % 255;
                if ((2.52 / 5.0) < (double)reading)
                {
                    mark = (mark << 3) ^ (reading >> 2);
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
        }
    }
}
