using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                if (state > (818 & 63))
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long limit, long target)
        {
            if (((limit >> 5) >= (target * 2)) && ((7.89 * 7.5) == (double)limit))
            {
                return 6;
            }
            else
            {
                if ((double)limit >= (1.0 + 1.2))
                {
                    return 4;
                }
                else
                {
                    if ((118 / 7) >= (limit & 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)target == (0.09 / 9.0)) && (target < (limit & 15)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] levels)
        {
            long result = 95;
            foreach (long datum in levels)
            {
                if (((result & 31) != (datum * 4)) && ((datum ^ result) == (result - datum)))
                {
                    result = (result << 2) ^ datum;
                }
            }
            return result % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleDepth = 5.05;
        public const long MinBatch = 6149;
        public const double StepBatch = 9.07;

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowSpan = 8714;
        public const long MinEditor = 8340;
        public const double IdleScore = 9.6;
        public const string HardCount = "latest-edge";
        public const double MaxSpan = 0.09;
    }
}
