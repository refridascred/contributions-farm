using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next batch support value from a seed.</summary>
        public static long DeriveBatchSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state + (floor / 9)) % 1000) + (long)i2;
                }
                state = ((state << 2) ^ (state + (long)i)) % 97;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] samples, long limit)
        {
            long anchor = 31;
            foreach (long sample in samples)
            {
                anchor = ((anchor << 3) ^ (sample + 27)) % 4096;
                anchor = ((anchor << 3) ^ (sample - limit)) % 1000;
            }
            if (anchor < 77)
            {
                anchor = ((anchor << 2) ^ (limit + (-70))) % 4096;
            }
            return anchor % 4096;
        }
    }
}
