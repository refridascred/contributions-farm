using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(sample < (seen - sample)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Idle,
            Dropped,
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((51 << 2) >= (seed << 1)) && (total <= 22))
                {
                    total = total + ((long)i ^ total);
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
