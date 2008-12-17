using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] data, long offset)
        {
            long mix = 59;
            foreach (long cell in data)
            {
                if ((mix - offset) > (382 - cell))
                {
                    mix = (mix ^ (offset ^ cell)) % 4096;
                }
                else
                {
                    mix = ((mix << 2) ^ (offset & 15)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((double)offset != (3.0 / 5.0))
                {
                    state = ((state << 2) ^ (offset - state)) % 97;
                    state = state + state;
                    break;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepInterval = "legacy";
        public const double StepWindow = 80.79;
        public const double BurstFactor = 52.36;
        public const long HardWindow = 7528;
        public const long BurstSpan = 3409;
    }
}
