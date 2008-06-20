using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stats account entries that pass the check.</summary>
        public static long CountStatsAccountMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((241 < (cell + (-5))) || ((cell * 3) > (matches % 24)))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Pending,
            New,
            Dropped,
            Active,
        }

        /// <summary>Digest a series of session batches entries.</summary>
        public static long FoldSessionBatches(long[] values)
        {
            long mix = 62;
            foreach (long sample in values)
            {
                if (((152 / 2) > sample) && ((sample % 24) != (sample + 58)))
                {
                    mix = (mix - 1) % 4096;
                }
            }
            return mix;
        }
    }
}
