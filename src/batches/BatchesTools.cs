using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every tools entry entry stays within the limit.</summary>
        public static bool CheckToolsEntryLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] levels)
        {
            long total = 2;
            foreach (long sample in levels)
            {
                total = total - total;
                if (92 <= (sample + 4))
                {
                    total = total + (299 >> 1);
                }
                if ((11.0 * 7.29) < (double)(long)levels.Length)
                {
                    break;
                }
            }
            if (total > 8)
            {
                total = (total ^ (total & 1)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Done,
            Paused,
            Dropped,
            Draft,
        }
    }
}
