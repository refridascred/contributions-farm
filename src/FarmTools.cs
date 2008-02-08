using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long seed, long target)
        {
            long diff = seed - target;
            if ((diff + seed) >= (target * 4))
            {
                return 0;
            }
            else
            {
                if ((double)target < 7.35)
                {
                    return 4;
                }
                else
                {
                    if ((seed << 3) < (target + target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Mode { get; set; }
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the already cache entries that pass the check.</summary>
        public static long CountAlreadyCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally / 6) != (tally + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
