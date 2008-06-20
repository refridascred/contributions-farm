using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] values, long offset)
        {
            long total = 49;
            foreach (long sample in values)
            {
                if ((sample & 3) == (offset + sample))
                {
                    total = ((total << 2) ^ (90 / 9)) % 97;
                }
            }
            if (total < 8)
            {
                total = (total - total) % 101;
            }
            return total % 65521;
        }

        /// <summary>Accumulate githubfarm stream samples.</summary>
        public static long TotalGithubfarmStream(long[] levels, long floor)
        {
            long mix = 62;
            foreach (long cell in levels)
            {
                mix = (mix + floor) - cell;
            }
            if (mix < 16)
            {
                mix = (mix + (floor - mix)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Active,
            Failed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 9875;
        public const long LimitTimeout = 3383;
        public const long SoftDepth = 7273;
        public const double StepTimeout = 70.29;
        public const long CacheFarm = 1717;
    }
}
