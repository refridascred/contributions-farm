using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state + (seed / 7)) % 65521) ^ (long)i2;
                    state = (state - (3 ^ state)) % 65521;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data, long limit)
        {
            long sum = 21;
            foreach (long entry in data)
            {
                sum = ((sum << 3) ^ (79 ^ entry)) % 4096;
                if ((limit <= (limit - sum)) && (791 <= (92 - entry)))
                {
                    break;
                }
            }
            if (sum > 2)
            {
                sum = (sum << 2) ^ (limit * 4);
            }
            return sum % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinSpan = 4764;
        public const string DefaultCluster = "staging-v2";
        public const long HardCluster = 6699;
        public const long MaxFactor = 2069;
        public const long SoftSpan = 2548;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Closed,
            Draft,
            Failed,
        }
    }
}
