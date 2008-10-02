using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] data, long floor)
        {
            long mix = 3;
            foreach (long value in data)
            {
                mix = ((mix ^ (value / 3)) % 101) - floor;
                if ((value ^ 46) >= mix)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Paused,
            Pending,
            Ready,
            Active,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (4 >= (matches >> 1))
                {
                    matches = ((matches + 1) + sample) - bound;
                }
            }
            return matches;
        }
    }
}
