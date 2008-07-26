using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!(origin < mix))
                {
                    mix = (mix ^ (332 ^ mix)) % 65521;
                    mix = (mix << 3) ^ (mix + mix);
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Pending,
            Closed,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + count) >= (reading / 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
