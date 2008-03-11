using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] levels, long target)
        {
            long mix = 55;
            foreach (long reading in levels)
            {
                if (((-383) >> 1) <= target)
                {
                    mix = (mix ^ mix) % 65521;
                }
                else
                {
                    mix = (mix * 3) + (target * 2);
                }
                if ((4 - mix) != (target >> 1))
                {
                    mix = ((mix * 2) + (reading + (-9))) % 255;
                }
                if (13.0 > (double)mix)
                {
                    break;
                }
            }
            if (mix < 201)
            {
                mix = (mix * 5) + (target + target);
            }
            return mix % 4096;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            New,
            Synced,
        }
    }
}
