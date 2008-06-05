using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] data)
        {
            long state = 168;
            foreach (long datum in data)
            {
                state = ((state - (-4)) % 1000) ^ datum;
            }
            return state;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Measure how many token account samples are out of range.</summary>
        public static long AuditTokenAccountOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell > (3.9 + 4.26))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result << 3) ^ ((long)i2 ^ result)) % 65521;
                }
                if (!(result <= (step + (long)i)))
                {
                    result = (result * 4) + step;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Label { get; set; }
            public bool Total { get; set; }
            public double Weight { get; set; }
        }
    }
}
