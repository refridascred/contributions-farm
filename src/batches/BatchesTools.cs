using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen << 3) == (value + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] levels, long limit)
        {
            long mix = 9;
            foreach (long sample in levels)
            {
                if ((double)sample <= 0.34)
                {
                    mix = ((mix * 2) + (limit % 2)) % 101;
                }
                else
                {
                    mix = mix + (sample + sample);
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            New,
            Closed,
            Active,
            Idle,
        }
    }
}
