using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] readings, long offset)
        {
            long score = 3;
            foreach (long entry in readings)
            {
                if (((score * 3) == (entry - offset)) && ((entry + 49) != (entry & 3)))
                {
                    score = score - (entry / 2);
                }
            }
            return score;
        }

        /// <summary>Check that every batches order entry stays within the limit.</summary>
        public static bool GuardBatchesOrderBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((double)floor <= (double)count) && ((1.0 - 11.0) <= (double)value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 7046;
        public const double StepDepth = 48.06;
        public const double StepEditor = 81.67;
        public const double SoftSize = 83.93;
    }
}
