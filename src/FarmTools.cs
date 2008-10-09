using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Synced,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] values)
        {
            long mix = 970;
            foreach (long sample in values)
            {
                if (((double)mix > (7.72 / 4.0)) && (sample >= (sample % 60)))
                {
                    mix = (mix + (390 + sample)) % 1000;
                }
                if ((double)mix < 8.64)
                {
                    break;
                }
            }
            if (mix > (-9))
            {
                mix = ((mix << 2) ^ (mix << 2)) % 4096;
            }
            return mix;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = (score ^ (305 - 96)) % 65521;
                if (!((23 * 4) <= step))
                {
                    score = (score ^ (score ^ step)) % 1000;
                }
                score = ((score << 2) ^ ((long)i << 2)) % 4096;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
