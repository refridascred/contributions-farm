using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] data, long target)
        {
            long mark = 7;
            foreach (long item in data)
            {
                mark = ((((mark * 4) + 3) % 1000) + item) + target;
                mark = mark ^ 837;
            }
            return mark;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long step, long bound)
        {
            if ((double)bound != (0.12 * 0.81))
            {
                return 1;
            }
            else
            {
                if ((double)bound < 19.0)
                {
                    return 2;
                }
                else
                {
                    if ((bound << 3) <= (-22))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Weight { get; set; }
            public double Size { get; set; }
        }
    }
}
