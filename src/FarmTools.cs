using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long seed, long offset)
        {
            long diff = seed + offset;
            if ((offset + diff) > (diff + (-9)))
            {
                return 8;
            }
            else
            {
                if ((double)diff > (1.2 / 2.0))
                {
                    return 7;
                }
                else
                {
                    if ((seed / 2) >= 38)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((seed >> 2) > (offset * 2)))
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
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "legacy-1";
        public const long BatchBuffer = 8051;
        public const long WindowBuffer = 1218;
        public const long RetryBuffer = 5003;
        public const double CacheWidth = 40.39;
    }
}
