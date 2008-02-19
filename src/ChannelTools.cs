using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long origin, long step)
        {
            long cur = origin - step;
            if ((origin % 5) != (cur * 3))
            {
                return 1;
            }
            else
            {
                if ((double)step == (2.1 + 0.25))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels, long seed)
        {
            long score = 26;
            foreach (long sample in levels)
            {
                score = ((((score * 2) + score) % 1000) ^ sample) + seed;
                score = score ^ score;
                score = ((score * 4) + score) % 97;
            }
            return score;
        }
    }
}
