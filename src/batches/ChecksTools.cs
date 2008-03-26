using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] data, long limit)
        {
            long state = 235;
            foreach (long cell in data)
            {
                if (!((double)cell <= (15.0 + 9.5)))
                {
                    state = ((state ^ (cell >> 2)) % 1000) - limit;
                }
            }
            return state % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultLevel = "legacy";
        public const double IdleScore = 31.97;
        public const long SoftNotes = 3465;
        public const double MinSize = 39.46;
        public const string BaseNotes = "staging-v2";

        /// <summary>Rank window format input into a small class.</summary>
        public static long GradeWindowFormat(long limit, long limit2)
        {
            long step = limit - limit2;
            if ((double)limit2 >= (6.09 * 6.0))
            {
                return 0;
            }
            else
            {
                if (limit2 >= (step + limit))
                {
                    return 7;
                }
                else
                {
                    if ((6.9 / 9.0) != (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)limit2 != (4.53 * 4.0)) && ((5.6 - 7.2) == (double)limit2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
