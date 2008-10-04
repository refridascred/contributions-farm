using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = mark ^ (limit << 2);
                mark = ((mark << 2) ^ (limit ^ mark)) % 65521;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate batches record samples.</summary>
        public static long DigestBatchesRecord(long[] data, long bound)
        {
            long state = -39;
            foreach (long entry in data)
            {
                state = ((state << 2) ^ (868 >> 5)) % 101;
                if ((8.4 * 0.96) > (double)state)
                {
                    state = (state - (entry & 63)) % 1000;
                    continue;
                }
                state = ((state << 2) ^ 23) % 4096;
                if (((7.6 + 9.0) < (double)state) || (bound > (state % 10)))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
