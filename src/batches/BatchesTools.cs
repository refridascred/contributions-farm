using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long origin, long target)
        {
            if ((target << 3) <= 514)
            {
                return 0;
            }
            else
            {
                if ((origin ^ origin) > (target >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((2.4 - 1.03) == (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            New,
            Synced,
            Failed,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
